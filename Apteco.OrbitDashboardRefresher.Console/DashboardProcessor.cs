using Apteco.OrbitDashboardRefresher.APIClient.Api;
using Apteco.OrbitDashboardRefresher.APIClient.Client;
using Apteco.OrbitDashboardRefresher.APIClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Apteco.OrbitDashboardRefresher.Console
{
  public class DashboardProcessor
  {
    private string apiUrl;
    private string dataViewName;
    private string username;
    private string password;

    public DashboardProcessor(string apiUrl, string dataViewName, string username, string password)
    {
      this.apiUrl = apiUrl;
      this.dataViewName = dataViewName;
      this.username = username;
      this.password = password;
    }
    public async Task ProcessDashboards()
    {
      var loginSessionsApi = new SessionsApi(CreateConfiguration(null));
      var sessionDetails = await loginSessionsApi.SessionsCreateSessionSimpleAsync(dataViewName, username, password);

      var usersApi = new UsersApi(CreateConfiguration(sessionDetails));
      var dashboards = await usersApi.UsersGetUserDashboardsAsync(dataViewName, username, count: 1000);

      var dashboardsApi = new DashboardsApi(CreateConfiguration(sessionDetails));

      var faststatsSystemsApi = new FastStatsSystemsApi(CreateConfiguration(sessionDetails));

      foreach (var dashboard in dashboards.List)
      {
        await ProcessDashboard(dashboard, usersApi, dashboardsApi, faststatsSystemsApi);
      }

      var logoutSessionsApi = new SessionsApi(CreateConfiguration(sessionDetails));
      await logoutSessionsApi.SessionsLogoutSessionAsync(dataViewName, sessionDetails.SessionId);
    }

    private async Task ProcessDashboard(UserDashboardSummary dashboard, UsersApi usersApi, DashboardsApi dashboardsApi, FastStatsSystemsApi faststatsSystemsApi)
    {
      try
      {
        System.Console.WriteLine($"Processing dashboard: {dashboard.Title}");
        var variableNameMap = await GetVariableNameMap(faststatsSystemsApi, dashboard.SystemName);
        var tableMap = await GetTableMap(faststatsSystemsApi, dashboard.SystemName);
        var dashboardDetails = await usersApi.UsersGetUserDashboardAsync(dataViewName, username, dashboard.Id);

        List<CalculateDashboardItemWithFilters> itemsToCalculate = new List<CalculateDashboardItemWithFilters>();
        foreach (var dashboarditem in dashboardDetails.DashboardItems)
        {
          itemsToCalculate.Add(new CalculateDashboardItemWithFilters()
          {
            DashboardItemId = dashboarditem.Id,
            ResolveTableName = GetResolveTableName(dashboarditem, tableMap, variableNameMap),
            UserFilterDefinition = null,
            DrillDownLevel = 0,
            SortOrder = CalculateDashboardItemWithFilters.SortOrderEnum.Natural,
            DimensionFilterDefinition = null
          });
        }
        var requestdata = new CalculateDashboardDataWithFilters(itemsToCalculate);
        var results = await dashboardsApi.DashboardsCalculateDashboardDataWithFiltersAsync(dataViewName, dashboard.Id, requestData: requestdata);
        var jobIds = results.Select(x => x.JobId).Where(x => x != null).ToList();

        System.Console.WriteLine($"{jobIds.Count} jobs found for dashboard: {dashboard.Title}");

        bool complete = false;
        while (!complete)
        {
          var jobDetails = await dashboardsApi.DashboardsBatchGetDashboardJobResultsAsync(dataViewName, dashboard.Id, jobIds);
          complete = jobDetails.Select(x => x.IsComplete).All(x => x == true);
          Thread.Sleep(1000);
        }
        System.Console.WriteLine($"All jobs complete for dashboard: {dashboard.Title}");

      }
      catch (ApiException e)
      {
        System.Console.WriteLine($"Caught error while processing dashboard {dashboard.Title}: {e.ErrorCode} {e.Message}");
      }
    }

    private string GetResolveTableName(DashboardContentItem dashboarditem, Dictionary<string, Table> tableMap, Dictionary<string, string> variableNameMap)
    {
      var dataSpecification = dashboarditem.DashboardItemDetails[0].DataSpecification;

      if (dataSpecification.CubeSpecification != null)
      {
        return GetCubeResolveTableName(dataSpecification.CubeSpecification, tableMap, variableNameMap);
      }
      if (dataSpecification.ParetoSpecification != null)
      {
        return dataSpecification.ParetoSpecification.ResolveTableName;
      }
      if (dataSpecification.VennSpecification != null)
      {
        return GetVennResolveTableName(dataSpecification.VennSpecification, tableMap, variableNameMap);
      }

      return null;
    }

    private string GetVennResolveTableName(VennSpecification vennSpecification, Dictionary<string, Table> tableMap, Dictionary<string, string> variableNameMap)
    {
      string resolveTableName = null;

      foreach (Measure m in vennSpecification.Measures)
      {
        string measureResolveTableName = null;
        if (m.VariableName != null)
        {
          measureResolveTableName = variableNameMap[m.VariableName];
        }
        else if (m.ResolveTableName != null)
        {
          measureResolveTableName = m.ResolveTableName;
        }
        else if (m.Query != null)
        {
          measureResolveTableName = m.Query.Selection?.TableName;
        }

        if (measureResolveTableName != null)
        {
          if (resolveTableName != null)
          {
            if (TableUtilities.IsAncestor(tableMap, resolveTableName, measureResolveTableName))
            {
              resolveTableName = measureResolveTableName;
            }
          }
          else
          {
            resolveTableName = measureResolveTableName;
          }
        }
      };

      return resolveTableName;
    }

    private string GetCubeResolveTableName(CubeSpecification cubeSpecification, Dictionary<string, Table> tableMap, Dictionary<string, string> variableNameMap)
    {
      string resolveTableName = null;

      foreach (Dimension d in cubeSpecification.Dimensions)
      {
        string dimensionResolveTableName = null;
        if (d.VariableName != null)
        {
          dimensionResolveTableName = variableNameMap[d.VariableName];
        }
        else if (d.Query != null)
        {
          dimensionResolveTableName = d.Query.Selection?.TableName;
        }

        if (dimensionResolveTableName != null)
        {
          if (resolveTableName != null)
          {
            if (TableUtilities.IsAncestor(tableMap, resolveTableName, dimensionResolveTableName))
            {
              resolveTableName = dimensionResolveTableName;
            }
          }
          else
          {
            resolveTableName = dimensionResolveTableName;
          }
        }
      };

      foreach (Measure m in cubeSpecification.Measures)
      {
        string measureResolveTableName = null;
        if (m.VariableName != null)
        {
          measureResolveTableName = variableNameMap[m.VariableName];
        }
        else if (m.ResolveTableName != null)
        {
          measureResolveTableName = m.ResolveTableName;
        }
        else if (m.Query != null)
        {
          measureResolveTableName = m.Query.Selection?.TableName;
        }

        if (measureResolveTableName != null)
        {
          if (resolveTableName != null)
          {
            if (TableUtilities.IsAncestor(tableMap, resolveTableName, measureResolveTableName))
            {
              resolveTableName = measureResolveTableName;
            }
          }
          else
          {
            resolveTableName = measureResolveTableName;
          }
        }
      };

      return resolveTableName;
    }

    private async Task<Dictionary<string, string>> GetVariableNameMap(FastStatsSystemsApi faststatsSystemsApi, string systemName)
    {
      var variables = await faststatsSystemsApi.FastStatsSystemsGetFastStatsVariablesAsync(dataViewName, systemName, count: 10000);
      return variables.List.ToDictionary(x => x.Name, x => x.TableName);
    }

    private async Task<Dictionary<string, Table>> GetTableMap(FastStatsSystemsApi faststatsSystemsApi, string systemName)
    {
      var variables = await faststatsSystemsApi.FastStatsSystemsGetFastStatsTablesAsync(dataViewName, systemName, count: 10000);
      return variables.List.ToDictionary(x => x.Name, x => x);
    }


    private Configuration CreateConfiguration(SessionDetails sessionDetails)
    {
      var defaultHeaders = new Dictionary<string, string>();
      if (sessionDetails != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
      }

      return new Configuration()
      {
        DefaultHeader = defaultHeaders,
        BasePath = apiUrl
      };
    }
  }
}

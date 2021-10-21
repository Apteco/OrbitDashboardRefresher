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

      foreach (var dashboard in dashboards.List)
      {
        await ProcessDashboard(dashboard, usersApi, dashboardsApi);
      }

      var logoutSessionsApi = new SessionsApi(CreateConfiguration(sessionDetails));
      await logoutSessionsApi.SessionsLogoutSessionAsync(dataViewName, sessionDetails.SessionId);
    }

    private async Task ProcessDashboard(UserDashboardSummary dashboard, UsersApi usersApi, DashboardsApi dashboardsApi)
    {
      try
      {
        System.Console.WriteLine($"Processing dashboard: {dashboard.Title}");
        var dashboardDetails = await usersApi.UsersGetUserDashboardAsync(dataViewName, username, dashboard.Id);

        List<CalculateDashboardItemWithFilters> itemsToCalculate = new List<CalculateDashboardItemWithFilters>();
        foreach (var dashboarditem in dashboardDetails.DashboardItems)
        {
          itemsToCalculate.Add(new CalculateDashboardItemWithFilters()
          {
            DashboardItemId = dashboarditem.Id,
            ResolveTableName = CalculateResolveTableName(dashboarditem),
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

    private string CalculateResolveTableName(DashboardContentItem dashboarditem)
    {
      return "People";
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

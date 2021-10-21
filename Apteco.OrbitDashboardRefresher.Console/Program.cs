using Apteco.OrbitDashboardRefresher.APIClient.Api;
using Apteco.OrbitDashboardRefresher.APIClient.Client;
using Apteco.OrbitDashboardRefresher.APIClient.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apteco.OrbitDashboardRefresher.Console
{
  class Program
  {
    static async Task Main(string[] args)
    {
      if (args.Length < 4)
      {
        System.Console.WriteLine("Usage: OrbitDashboardRefresher.exe <api URL> <data view name> <username> <password>");
        return;
      }

      string apiUrl = args[0];
      string dataViewName = args[1];
      string username = args[2];
      string password = args[3];

      await new Program().LoginAndListAvailableFastStatsSystems(apiUrl, dataViewName, username, password);
    }

    private async Task LoginAndListAvailableFastStatsSystems(string apiUrl, string dataViewName, string username, string password)
    {
      var loginSessionsApi = new SessionsApi(CreateConfiguration(apiUrl, null));
      var sessionDetails = await loginSessionsApi.SessionsCreateSessionSimpleAsync(dataViewName, username, password);

      var usersApi = new UsersApi(CreateConfiguration(apiUrl, sessionDetails));
      var dashboards = await usersApi.UsersGetUserDashboardsAsync(dataViewName, username, count: 1000);

      foreach (var dashboard in dashboards.List)
      {
        System.Console.WriteLine(dashboard.Title);
      }

      var logoutSessionsApi = new SessionsApi(CreateConfiguration(apiUrl, sessionDetails));
      await logoutSessionsApi.SessionsLogoutSessionAsync(dataViewName, sessionDetails.SessionId);
    }

    private Configuration CreateConfiguration(string apiUrl, SessionDetails sessionDetails)
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

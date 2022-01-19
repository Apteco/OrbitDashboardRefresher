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
        System.Console.WriteLine($"OrbitDashboardRefresher version {typeof(DashboardProcessor).Assembly.GetName().Version}");
        System.Console.WriteLine();
        System.Console.WriteLine("Usage: OrbitDashboardRefresher.exe <api URL> <data view name> <username or email address> <password>");
        return;
      }

      string apiUrl = args[0];
      string dataViewName = args[1];
      string username = args[2];
      string password = args[3];

      await new DashboardProcessor(apiUrl, dataViewName, username, password).ProcessDashboards();
    }

  }
}

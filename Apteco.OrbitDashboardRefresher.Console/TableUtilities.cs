using Apteco.OrbitDashboardRefresher.APIClient.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apteco.OrbitDashboardRefresher.Console
{
  public class TableUtilities
  {
    public static bool IsAncestor(Dictionary<string, Table> tableMap, string sourceTable, string destinationTable)
    {
      if (!tableMap.ContainsKey(destinationTable))
      {
        return false;
      }
      Table currentchild = tableMap[destinationTable];
      while (!string.IsNullOrEmpty(currentchild.ParentTable))
      {
        if (currentchild.ParentTable == sourceTable)
        {
          return true;
        }
        if (!tableMap.ContainsKey(currentchild.ParentTable))
        {
          throw new Exception($"Table: {currentchild.ParentTable} could not be found");
        }
        currentchild = tableMap[currentchild.ParentTable];
      }
      return false;
    }

    public static string GetLowestResolveTable(Dictionary<string, Table> tableMap, string resolveTableName1, string resolveTableName2)
    {
      if (resolveTableName1 != null && resolveTableName2 != null)
        return IsAncestor(tableMap, resolveTableName1, resolveTableName2) ? resolveTableName2 : resolveTableName1;
      else
        return resolveTableName1 != null ? resolveTableName1 : resolveTableName2;
    }
  }
}

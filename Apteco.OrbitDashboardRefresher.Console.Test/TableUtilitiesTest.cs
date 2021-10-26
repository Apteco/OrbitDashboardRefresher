using Apteco.OrbitDashboardRefresher.APIClient.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Apteco.OrbitDashboardRefresher.Console.Test
{
  [TestFixture]
  public class TableUtilitiesTest
  {
    [Test]
    public void TestSameTableIsntSAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "People", "People"), Is.False);
    }

    [Test]
    public void TestPeopleToBookingsIsAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "People", "Bookings"), Is.True);
    }

    [Test]
    public void TestBookingsToPeopleIsntAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "Bookings", "People"), Is.False);
    }

    [Test]
    public void TestHouseholdsToPeopleIsAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "Households", "People"), Is.True);
    }

    [Test]
    public void TestHouseholdsToBookingsIsAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "Households", "Bookings"), Is.True);
    }

    [Test]
    public void TestPeopleToHouseholdsIsntAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "People", "Households"), Is.False);
    }

    [Test]
    public void TestBookingsToHouseholdsIsntAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "Bookings", "Households"), Is.False);
    }

    [Test]
    public void TestWibbletoPeopleIsntAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "Wibble", "People"), Is.False);
    }

    [Test]
    public void TestPeopleToWibbleIsntAncestor()
    {
      var tablesMap = CreateHolidaysTables();
      Assert.That(TableUtilities.IsAncestor(tablesMap, "People", "Wibble"), Is.False);
    }

    private Dictionary<string, Table> CreateHolidaysTables()
    {
      Dictionary<string, Table> tablesMap = new Dictionary<string, Table>();
      tablesMap.Add("Households", CreateTable("Households", ""));
      tablesMap.Add("People", CreateTable("People", "Households"));
      tablesMap.Add("Bookings", CreateTable("People", "People"));
      tablesMap.Add("Policies", CreateTable("Policies", "People"));
      return tablesMap;
    }

    private Table CreateTable(string name, string parentTable)
    {
      return new Table(name: name, singularDisplayName: name, pluralDisplayName: name, isDefaultTable: false, isPeopleTable: false, totalRecords: 0, childRelationshipName: "", parentRelationshipName: "", hasChildTables: false, parentTable: parentTable);
    }
  }
}

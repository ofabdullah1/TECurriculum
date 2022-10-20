using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private static readonly Timesheet TIMESHEET_1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private static readonly Timesheet TIMESHEET_2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private static readonly Timesheet TIMESHEET_3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private static readonly Timesheet TIMESHEET_4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private TimesheetSqlDao dao;


        [TestInitialize]
        public override void Setup()
        {
            dao = new TimesheetSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            Timesheet timesheet = dao.GetTimesheet(1);
            AssertTimesheetsMatch(TIMESHEET_1, timesheet);

            timesheet = dao.GetTimesheet(2);
            AssertTimesheetsMatch(TIMESHEET_2, timesheet);
        }

        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            Timesheet timesheet = dao.GetTimesheet(99);
            Assert.IsNull(timesheet);
        }

        [TestMethod]
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet timesheet = new Timesheet();
            timesheet.TimesheetId = 1;
            timesheet.EmployeeId = 1;
            timesheet.ProjectId = 1;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 1.0M;
            timesheet.IsBillable = true;
            timesheet.Description = "Timesheet 1";


           

            Timesheet createdTimesheet = dao.CreateTimesheet(timesheet);


            int newId = createdTimesheet.ProjectId;
            Timesheet retrievedTimesheet = dao.GetTimesheet(newId);

            Assert.AreEqual(timesheet.EmployeeId, retrievedTimesheet.EmployeeId);
            Assert.AreEqual(timesheet.ProjectId, retrievedTimesheet.ProjectId);


        }

        [TestMethod]
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet timesheet = dao.GetTimesheet(1);

            timesheet.TimesheetId = 1;
            timesheet.EmployeeId = 1;
            timesheet.ProjectId = 1;
            timesheet.DateWorked = DateTime.Parse("2021-01-01");
            timesheet.HoursWorked = 1.0M;
            timesheet.IsBillable = true;
            timesheet.Description = "Timesheet 1";

            dao.UpdateTimesheet(timesheet);

            Timesheet retrievedtimesheet = dao.GetTimesheet(1);
            AssertTimesheetsMatch(timesheet, retrievedtimesheet);

        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetBillableHours_ReturnsCorrectTotal()
        {
            Decimal timesheets = dao.GetBillableHours(2,2);

            Assert.AreEqual(0M, timesheets);


        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}

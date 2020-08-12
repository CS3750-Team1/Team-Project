using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Coding_Coalition_Project.Pages.AddClass;
using Coding_Coalition_Project.Pages.AddAssignments;
using Coding_Coalition_Project.Pages.AddCourseSubject;
using Moq;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Coding_Coalition_Project.Migrations;
using Coding_Coalition_Project.Models;
using System.Linq;
using Coding_Coalition_Project.Pages.ViewAssignments;
using Microsoft.VisualBasic;

namespace UnitTests
{
    [TestClass]
    public class testAddAssignment
    {

        [TestMethod]
        public void TestingTuitionCost()
        {

            int result = UserInfo.calcCost(5);
            Assert.AreEqual(50000, result, "Error");
        }

        [TestMethod]
        public void TestingScore()
        {
            List<int> scores = new List<int> { 33, 78, 42, 69, 50 };
            Assert.AreEqual(SubmitAssignment.calcScore(scores), 272, "Calculation Error");
        }

        [TestMethod]
        public void TestingPossibleScore()
        {
            List<int> scores = new List<int> { 33, 78, 42, 69, 50 };
            Assert.AreEqual(SubmitAssignment.calcPossibleScore(scores), 272, "Calculation Error");
        }

        [TestMethod]
        public void TestingBoxPlot()
        {
            //Testing Even indexed arrays
            List<int> escores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> eshouldReturn = new List<int> { 1, 3, 5, 8, 10 };
            List<int> etemp = SubmitAssignment.calulateBoxPlot(escores);
            CollectionAssert.AreEqual(etemp, eshouldReturn);

            //Testing Odd indexed arrays
            List<int> oscores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> oshouldReturn = new List<int> { 1, 2, 5, 7, 9 };
            List<int> otemp = SubmitAssignment.calulateBoxPlot(oscores);
            CollectionAssert.AreEqual(otemp, oshouldReturn);

            //Testing Even indexed arrays
            List<int> zscores = new List<int>();
            List<int> zshouldReturn = new List<int> { 0,0,0,0,0 };
            List<int> ztemp = SubmitAssignment.calulateBoxPlot(zscores);
            CollectionAssert.AreEqual(ztemp, zshouldReturn);

            //Testint Arrays with one index
            List<int> sscores = new List<int> { 5 };
            List<int> sshouldReturn = new List<int> { 5,5,5,5,5 };
            List<int> stemp = SubmitAssignment.calulateBoxPlot(sscores);
            CollectionAssert.AreEqual(stemp, sshouldReturn);
        }

        [TestMethod]
        public void TestcalcScoreWithNegatives()
        {
            //Test if Possible Score still calculates with a negative
            List<int> scores = new List<int> { -1, 89, 77, 32, 10 };
            Assert.AreEqual(SubmitAssignment.calcScore(scores), 207, "Calculation Error - Negatives");
        }

        [TestMethod]
        public void TestcalcPossibleScoreWithNegatives()
        {
            //Test if Possible Score still calculates with a negative
            List<int> scores = new List<int> { -1, 89, 77, 32, 10 };
            Assert.AreEqual(SubmitAssignment.calcPossibleScore(scores), 207, "Calculation Error - Negatives");
        }

        [TestMethod]
        public void TestCalculateAccount()
        {
            // test to see that student doesn't pay more than they owe
            List<int> amount1 = new List<int> { 500, 1000, 1200, 1500 };
            List<int> amount2 = new List<int> { 499, 800, 1, 1500};
            Assert.AreEqual(UserInfo.CalculateAccount(amount1, amount2), true, "User paid more than they owed");
        }

        [TestMethod]
        public void TestCalenderUserID()
        {
            // Testing that calender has a userId attached
            Assert.AreEqual(Calender.TestUserID(1), true, "No userID attached to calender event");
        }

        [TestMethod]
        public void TestUserInstructor()
        {
            // Testing if the user is instructor
            Assert.AreEqual(UserInfo.CheckInstructor(true), true, "User is not an instructor");
        }

        [TestMethod]
        public void TestCourseNumber()
        {
            // Testing if the user is instructor
            Assert.AreEqual(Coding_Coalition_Project.Models.Courses.CheckCourseNumber(1), true, "Course can't be 0");
        }

        [TestMethod]
        public void TestAnnouncementsUserID()
        {
            // Testing that announcements has a userID attached
            Assert.AreEqual(Announcements.TestUserID(1), true, "No userID attached to announcements");
        }

        [TestMethod]
        public void TestUJCUserID()
        {
            // Testing that UJC has a userID attached
            Assert.AreEqual(UserJunctionCourses.TestUserID(1), true, "No userID attached to UJC");
        }

          [TestMethod]
        public void TestClassID()
        {
            // Testing that assignment has a ClassID attached
            Assert.AreEqual(Assignments.ClassID(1), true, "No ClassID attached to Assignments");
        }

    }
}

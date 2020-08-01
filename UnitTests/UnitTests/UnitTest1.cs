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

namespace UnitTests
{
    [TestClass]
    public class testAddAssignment
    {
        /*
        [Fact]
        public async Task AddAssignment_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            var mockDB = new Mock<Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext>();
            var controller = new AddAssignmentsModel(mockDB.Object);
            controller.ModelState.AddModelError("error", "Model is Invalid");
            

            // Act
            var result = await controller.OnPostAsync();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }

    public class testAddClass
    {
        [Fact]
        public async Task AddClass_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            // Arrange
            var mockDB = new Mock<Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext>();
            var controller = new AddClassModel(mockDB.Object);
            controller.ModelState.AddModelError("error", "Model is Invalid");

            // Act
            var result = await controller.OnPostAsync();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }

    public class testAddAnnouncements
    {
        [Fact]
        public async Task AddAnnouncements_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            // Arrange
            var mockDB = new Mock<Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext>();
            var controller = new IdeasController(mockDB.Object);
            controller.ModelState.AddModelError("error", "Model is Invalid");

            // Act
            var result = await controller.OnPostAsync();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }

    public class testAddCourseSubject
    {
        [Fact]
        public async Task AddCourseSubject_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            // Arrange
            var mockDB = new Mock<Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext>();
            var controller = new AddCourseSubjectModel(mockDB.Object);
            controller.ModelState.AddModelError("error", "Model is Invalid");

            // Act
            var result = await controller.OnPostAsync();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }

     

        [Fact]
        public async Task AddCourseSubject_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            // Arrange
            var mockDB = new Mock<Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext>();
            var controller = new AddCourseSubjectModel(mockDB.Object);
            controller.ModelState.AddModelError("error", "Model is Invalid");
            
            // Act
            var result = await controller.OnPostAsync();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }

     public class testAddUserJunctionCourses
    {
        [Fact]
        public async Task AddUserJunctionCourses_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            // Arrange
            var mockDB = new Mock<Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext>();
            var controller = new AddUserJunctionCoursesModel(mockDB.Object);
            controller.ModelState.AddModelError("error", "Model is Invalid");

            // Act
            var result = await controller.OnPostAsync();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }
       */


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
    }
}

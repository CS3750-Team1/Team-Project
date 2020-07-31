using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Coding_Coalition_Project.Pages;
using Coding_Coalition_Project.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using Coding_Coalition_Project.Pages.AddClass;
using Coding_Coalition_Project.Pages.AddAssignments;
using Coding_Coalition_Project.Pages.AddCourseSubject;

namespace UnitTests
{
    public class testAddAssignment
    {
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
}

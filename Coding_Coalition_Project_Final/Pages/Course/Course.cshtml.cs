using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coding_Coalition_Project.Pages.Course
{
    public class CourseModel : PageModel
    {
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }

        public void OnGet(string courseName, string courseNumber)
        {
            CourseName = courseName;
            CourseNumber = courseNumber;
        }
    }
}
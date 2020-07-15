using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coding_Coalition_Project.Pages.Course
{
    public class CourseModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;
        public CourseModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public int CourseID = -1;
        public Courses userCourses { get; set; }

        public void OnGet(string courseName, string courseNumber)
        {
            var UCourses = _context.Courses.Where(x => x.CourseNumber.ToString() == courseNumber);
            //UCourses = UCourses.Where(x => x.CourseName == courseName);
            UCourses = UCourses.Where(m=>m.CourseName == courseName);
            userCourses = UCourses.FirstOrDefault(x => x.CourseName == courseName) ;
            CourseName = courseName;
            CourseNumber = courseNumber;
            if (CourseID == -1 && HttpContext.Session.GetInt32("CourseID") == null)
            {
                CourseID = userCourses.CourseID;
                HttpContext.Session.SetInt32("CourseID", userCourses.CourseID);
            }
        }
    }
}
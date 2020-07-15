using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;

namespace Coding_Coalition_Project.Pages.UserCourses
{
    public class UserCoursesModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public UserCoursesModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<Courses> Courses { get;set; }
        private int IsInstructor;

        public void SetIsInstructor(int temp)
        {
            IsInstructor = temp;
        }
        public async Task OnGetAsync()
        {
            var id = HttpContext.Session.GetInt32("UserID");
            UserInfo userInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);
            Courses = await _context.Courses.ToListAsync();
            
            if (userInfo.IsInstructor)
            {
                SetIsInstructor(1);
            }
            else
            {
                SetIsInstructor(0);
            }
            List<UserJunctionCourses> courses = _context.UserJunctionCourses.ToList();
            List<Courses> uCourses = new List<Courses>();
            if (IsInstructor != 1)
            {
                foreach (UserJunctionCourses ujc in courses)
                {
                    if (ujc.UserID == id)
                    {
                        Courses course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseID == ujc.CourseID);
                        uCourses.Add(course);
                    }
                }
            }
            else
            {
                List<Courses> icourse1 = _context.Courses.ToList();
                foreach (Courses icourse in icourse1)
                {
                    if (icourse.InstructorID == id)
                    {
                        uCourses.Add(icourse);
                    }
                }

            }

            Courses = uCourses;
        }
    }
}

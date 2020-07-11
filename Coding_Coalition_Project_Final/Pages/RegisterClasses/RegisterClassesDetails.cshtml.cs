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
using Microsoft.EntityFrameworkCore.Internal;

namespace Coding_Coalition_Project.Pages.RegisterClasses
{
    
    public class RegisterClassesDetailsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public RegisterClassesDetailsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public Courses Courses { get; set; }
        
        UserJunctionCourses userJunctionCourses = new UserJunctionCourses();
        public void setCourseID(int id)
        {
            Console.WriteLine("ID = " + id);
            HttpContext.Session.SetInt32("CourseID", id);
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {

            Console.WriteLine($"UserID returned: " + HttpContext.Session.GetInt32("UserID"));
            if (id == null)
            {
                return NotFound();
            }

            Courses = await _context.Courses.FirstOrDefaultAsync(m => m.CourseID == id);

            if (Courses == null)
            {
                return NotFound();
            }
       
            
            return Page();
        }

 //       public UserJunctionCourses userJunctionCourses;

        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine("courseid = " + (int)HttpContext.Session.GetInt32("CourseID"));

            userJunctionCourses.UserID = (int)HttpContext.Session.GetInt32("UserID");
            userJunctionCourses.CourseID = (int)HttpContext.Session.GetInt32("CourseID");


            _context.UserJunctionCourses.Add(userJunctionCourses);
            await _context.SaveChangesAsync();
            return RedirectToPage("./RegisterClasses");
        }
    }
}

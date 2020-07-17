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
        int costPerCredit = 10000;

        public RegisterClassesDetailsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public UserInfo UserInfo { get; set; }

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

            id = HttpContext.Session.GetInt32("UserID");
            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

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
            
            var id = HttpContext.Session.GetInt32("CourseID");
            if (id == null)
            {
                return NotFound();
            }

            Courses = await _context.Courses.FirstOrDefaultAsync(m => m.CourseID == id);

            id = HttpContext.Session.GetInt32("UserID");
            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

            userJunctionCourses.UserID = (int)HttpContext.Session.GetInt32("UserID");
            userJunctionCourses.CourseID = (int)HttpContext.Session.GetInt32("CourseID");

            int cost = costPerCredit * Courses.CourseCredits;

            UserInfo.CreditHours = UserInfo.CreditHours + Courses.CourseCredits;
            UserInfo.AccountCharges = UserInfo.AccountCharges + cost;



            var Users = from m in _context.UserJunctionCourses select m;
            Users = Users.Where(x => x.CourseID.Equals(userJunctionCourses.CourseID));
            Users = Users.Where(y => y.UserID.Equals(userJunctionCourses.UserID));



            if (Users.Count() == 0)
            {
                _context.UserJunctionCourses.Add(userJunctionCourses);
                _context.UserInfo.Update(UserInfo);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./RegisterClasses");
        }
    }
}

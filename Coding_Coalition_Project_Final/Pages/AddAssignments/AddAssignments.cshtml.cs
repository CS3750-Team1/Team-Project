using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;

namespace Coding_Coalition_Project.Pages.AddAssignments
{
    public class AddAssignmentsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AddAssignmentsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Assignments Assignments { get; set; }
        public string subType { get; set; }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            subType = Request.Form["subType"];
            Assignments.submissionType = subType;
            Assignments.AssignmentType = Request.Form["assignType"];
            Assignments.ClassID = (int)HttpContext.Session.GetInt32("CourseID");
            _context.Assignments.Add(Assignments);
            await _context.SaveChangesAsync();

            return RedirectToPage("../MainPage/MainPage");
        }
    }
}

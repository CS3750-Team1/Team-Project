using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;

namespace Coding_Coalition_Project.Pages.AddClass
{
    public class AddClassModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AddClassModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Courses Courses { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Courses.Add(Courses);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}

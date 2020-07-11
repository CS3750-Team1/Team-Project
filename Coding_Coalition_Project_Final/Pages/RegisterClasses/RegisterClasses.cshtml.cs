using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;

namespace Coding_Coalition_Project.Pages
{
    public class RegisterClassesModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public RegisterClassesModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<Courses> Courses { get;set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses.ToListAsync();
        }
    }
}

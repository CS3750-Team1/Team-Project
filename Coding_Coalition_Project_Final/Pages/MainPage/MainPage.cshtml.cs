using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coding_Coalition_Project.Pages.MainPage
{
    public class MainPageModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public MainPageModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserInfo UserInfo { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
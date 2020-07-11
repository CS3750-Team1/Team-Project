using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Coding_Coalition_Project.Models;
using DHTMLX.Scheduler;

namespace Coding_Coalition_Project.Pages.Calender
{
    public class CalenderModel : PageModel
    {

        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public CalenderModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
     

    }
}

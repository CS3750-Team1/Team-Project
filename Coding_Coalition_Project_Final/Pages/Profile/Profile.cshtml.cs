using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Coding_Coalition_Project.Pages.Profile
{
    public class ProfileModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public ProfileModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public UserInfo UserInfo { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var id = HttpContext.Session.GetInt32("UserID");
            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (UserInfo == null)
            {
                return NotFound();
            }

            Console.WriteLine("ID = " + id.ToString());

            /*
            var user = from u in _context.UserInfo select u;
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                user = user.Where(s => s.ID.ToString().Contains(id.ToString()));
            }

            */

            return Page();

        }
    }
}
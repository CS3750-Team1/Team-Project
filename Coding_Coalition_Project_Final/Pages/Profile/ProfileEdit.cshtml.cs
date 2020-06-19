using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Coding_Coalition_Project.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Coding_Coalition_Project.Pages.Profile
{
    public class ProfileEditModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public ProfileEditModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {

            if (await TryUpdateModelAsync<UserInfo>(UserInfo,"userinfo", s => s.FirstName, s => s.LastName, s => s.Email,
                    s => s.Birthdate, s => s.Password, s => s.IsInstructor))
            {
                UserInfo.Password = Hash.Create(PasswordEncryption.EncryptString(UserInfo.Password));

                _context.UserInfo.Update(UserInfo);
                await _context.SaveChangesAsync();
                return RedirectToPage("../Profile/Profile");
            }

            return Page();

        }
    }
}
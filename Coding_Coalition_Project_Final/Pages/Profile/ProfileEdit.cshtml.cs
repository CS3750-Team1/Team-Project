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

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(UserInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(UserInfo.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            UserInfo.Password = Hash.Create(PasswordEncryption.EncryptString(UserInfo.Password));
            HttpContext.Session.SetString("FirstName", (from m in _context.UserInfo select m.FirstName).Single());
            HttpContext.Session.SetString("LastName", (from m in _context.UserInfo select m.LastName).Single());
            HttpContext.Session.SetInt32("UserID", (from m in _context.UserInfo select m.ID).Single());

            if (UserInfo.IsInstructor)
            {
                HttpContext.Session.SetInt32("IsInstructor", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("IsInstructor", 0);
            }

            _context.UserInfo.Add(UserInfo);
            await _context.SaveChangesAsync();
            return RedirectToPage("../Profile/Profile");
        }

        private bool UserExists(int id)
        {
            return _context.UserInfo.Any(e => e.ID == id);
        }
    }
}
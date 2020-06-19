﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            var Users = from m in _context.UserInfo select m;
            int UserID = (int)HttpContext.Session.GetInt32("UserID");
            Users = Users.Where(x => x.ID.Equals(UserID));

            if (await TryUpdateModelAsync<UserInfo>(UserInfo,"userinfo", s => s.FirstName, s => s.LastName, s => s.Email,
                    s => s.Birthdate, s => s.Password, s => s.IsInstructor))
            {
                if(UserInfo.Password == null)
                {
                    UserInfo.Password = (from m in Users select m.Password).Single();
                }
                else
                {
                    UserInfo.Password = Hash.Create(PasswordEncryption.EncryptString(UserInfo.Password));
                }

                if(UserInfo.UserImage == null)
                {
                    UserInfo.UserImage = (from m in Users select m.UserImage).Single();
                }
                else
                {
                    Image tempImage = Image.FromFile(UserInfo.ImagePath);
                    var ms = new MemoryStream();
                    tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    UserInfo.UserImage = ms.ToArray();

                }
                UserInfo.ImagePath = "Image added successfully";
                UserInfo.Biography = (from m in Users select m.Biography).Single();



                _context.UserInfo.Update(UserInfo);
                await _context.SaveChangesAsync();
                return RedirectToPage("../Profile/Profile");
            }

            return Page();

        }
    }
}
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Coding_Coalition_Project.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Coding_Coalition_Project.Pages.Profile
{
    public class ProfileEditModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;
        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public ProfileEditModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context, IHostingEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }

        [BindProperty]
        public UserInfo UserInfo { get; set; }

        [BindProperty]
        public IFormFile FormImage { set; get; }

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


            return Page();

        }

        [Obsolete]
        public async Task<IActionResult> OnPostAsync()
        {
            var Users = from m in _context.UserInfo select m;
            int UserID = (int)HttpContext.Session.GetInt32("UserID");
            Users = Users.Where(x => x.ID.Equals(UserID));
            

            if (await TryUpdateModelAsync<UserInfo>(UserInfo, "userinfo", s => s.FirstName, s => s.LastName, s => s.Email,
                    s => s.Birthdate, s => s.Password, s => s.Biography, s => s.Twitter, s => s.Linkedin, s => s.Facebook, s => s.IsInstructor))
            {
                if (UserInfo.Password == null)
                {
                    UserInfo.Password = (from m in Users select m.Password).Single();
                }
                else
                {
                    UserInfo.Password = Hash.Create(PasswordEncryption.EncryptString(UserInfo.Password));
                }

                if (this.FormImage != null)
                {

                    using var memoryStream = new MemoryStream();
                    await FormImage.CopyToAsync(memoryStream);
                    Image img = Image.FromStream(memoryStream);
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    UserInfo.UserImage = memoryStream.ToArray();
                    UserInfo.ImagePath = null;
                }

                UserInfo.Biography = (from m in Users select m.Biography).Single();

                _context.UserInfo.Update(UserInfo);
                await _context.SaveChangesAsync();
                return RedirectToPage("../Profile/Profile");
            }

            return Page();

        }

        private string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }
    }
}
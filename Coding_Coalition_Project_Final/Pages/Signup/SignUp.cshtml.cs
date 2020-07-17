using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Coding_Coalition_Project.Security;
using System.Linq;
using Microsoft.CodeAnalysis;
using System.Data;
using Coding_Coalition_Project.Migrations;
using System.Drawing;
using System.IO;

namespace Coding_Coalition_Project.Pages.Signup
{
    public class SignUpModel : PageModel
    {
        
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public SignUpModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();

        }

        [BindProperty]
        public UserInfo UserInfo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if(UserInfo.Password == null)
            {
                return null;
            }
            
                Image tempImage = Image.FromFile("Images/DefaultImage.jpg");
                var ms = new MemoryStream();
                tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                UserInfo.UserImage = ms.ToArray();
                UserInfo.ImagePath = "~/Images/DefaultImage.jpg";
            UserInfo.Twitter = "https://twitter.com";
            UserInfo.Linkedin = "https://www.linkedin.com/";
            UserInfo.Linkedin = "https://www.facebook.com/";
            UserInfo.CreditHours = 0;
            UserInfo.Biography = "Temporary";
            UserInfo.AccountCharges = 0;
            UserInfo.AccountPayments = 0;




            if (!ModelState.IsValid)
            {
                return Page();
            }



            // hash password
            UserInfo.Password = Hash.Create(PasswordEncryption.EncryptString(UserInfo.Password));


            var Users = from x in _context.UserInfo select x;

            Users = Users.Where(s => s.Email.Equals(UserInfo.Email));


            if (Users.Count() == 0)
            {
                _context.UserInfo.Add(UserInfo);
                await _context.SaveChangesAsync();

                return RedirectToPage("../SignIn/signin");
            }
            else
            {
                return null;
            }

        }
    }
}

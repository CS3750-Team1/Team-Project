using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Coding_Coalition_Project.Security;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

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

            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpContext.Session.Clear();

            HttpContext.Session.SetString("FirstName", UserInfo.FirstName);
            HttpContext.Session.SetString("LastName", UserInfo.LastName);
            HttpContext.Session.SetInt32("UserID", UserInfo.ID);

            if(UserInfo.IsInstructor)
            {
                HttpContext.Session.SetInt32("IsInstructor", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("IsInstructor", 0);
            }

            // encrypt password using Security.PasswordEncryption
            // add data protection services
            //var serviceCollection = new ServiceCollection();
            //serviceCollection.AddDataProtection();
            //var services = serviceCollection.BuildServiceProvider();
            //var encryption = ActivatorUtilities.CreateInstance<PasswordEncryption>(services);


            // hash password
            UserInfo.Password = Hash.Create(PasswordEncryption.EncryptString(UserInfo.Password));

            _context.UserInfo.Add(UserInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("../MainPage/MainPage");
        }
    }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Coding_Coalition_Project.Security;
using Microsoft.Extensions.DependencyInjection;

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
            HttpContext.Session.SetInt32("UserID", UserInfo.ID);

            // encrypt password using Security.PasswordEncryption
            // add data protection services
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDataProtection();
            var services = serviceCollection.BuildServiceProvider();
            var encryption = ActivatorUtilities.CreateInstance<PasswordEncryption>(services);

            // hash password
            string passwordHash = Hash.Create(encryption.EncryptInput(UserInfo.Password));

            HttpContext.Session.SetString("Password", passwordHash);

            _context.UserInfo.Add(UserInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}

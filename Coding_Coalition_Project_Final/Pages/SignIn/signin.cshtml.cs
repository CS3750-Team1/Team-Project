using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace Coding_Coalition_Project.Pages.SignIn
{
    public class signinModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public signinModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        //public void OnGet()
        public IActionResult OnGet()
        {
            return Page();

        }
/*
        [BindProperty]
       public SignInViewModel SignInViewModel { get; set; }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(UserInfo model)
       {
            if (!ModelState.IsValid)
            {
                var user = new ApplicationUser() { UserName = model.Email };
                var result = await _context.CreateAsync(user, model.Password);
                if (result.Succeeded)
               {
                    await SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
           }

          return View(model);
     }

        */
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Coding_Coalition_Project.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Coding_Coalition_Project.Pages.SignIn
{
    public class SignInModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public SignInModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<UserInfo> UserInfo { get;set; }
        [BindProperty(SupportsGet = true)]
        public string UserEmail { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserPassword { get; set; }
        public Boolean validInfo = false;


        public async Task<RedirectToPageResult> OnGetAsync()
        {
            HttpContext.Session.Clear();
            var Users = from m in _context.UserInfo select m;
            if(!string.IsNullOrEmpty(UserEmail) && !string.IsNullOrEmpty(UserPassword))
            {
                HttpContext.Session.SetString("Password", UserPassword);
                // hash password
                UserPassword = Hash.Create(PasswordEncryption.EncryptString(UserPassword));


                UserEmail = UserEmail.ToLower();
                Users = Users.Where(s => s.Email.Equals(UserEmail));
                Users = Users.Where(t => t.Password.Equals(UserPassword));



                if (Users.Count() == 0)
                {
                    //Need code to display error message
                }
                else if(Users.Count() == 1)                {

                    HttpContext.Session.SetString("FirstName",(from m in Users select m.FirstName).Single()) ;
                    HttpContext.Session.SetString("LastName", (from m in Users select m.LastName).Single());
                    HttpContext.Session.SetInt32("UserID", (from m in Users select m.ID).Single());
                    if ((from m in Users select m.IsInstructor).Single() == true)
                    {
                        HttpContext.Session.SetInt32("IsInstructor", 0);
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("IsInstructor", 1);
                    }
                    return RedirectToPage("../MainPage/MainPage");
          //          UserInfo = await Users.ToListAsync();


                }
            }
                UserInfo = await Users.ToListAsync();
                return null;

            //            UserInfo = await _context.UserInfo.ToListAsync();
        }


    }
}

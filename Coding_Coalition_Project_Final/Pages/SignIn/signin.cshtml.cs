using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;


namespace Coding_Coalition_Project.Pages.SignIn
{
    public class signinModel : PageModel
    {
        public void OnGet()
        {

        }

        public UserInfo UserInfo { get; set; }
    }
}
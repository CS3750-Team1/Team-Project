using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coding_Coalition_Project.Pages.Profile
{
    public class ProfileModel : PageModel
    {
        public UserInfo UserInfo { get; set; }

        public void OnGet()
        {

        }
    }
}
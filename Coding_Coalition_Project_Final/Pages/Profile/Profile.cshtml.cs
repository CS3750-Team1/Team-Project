using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Coding_Coalition_Project.Pages.Profile
{
    public class ProfileModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public ProfileModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }



//       public string getImageString()
//       {
//            return imageString;
//       }
        
        public UserInfo UserInfo { get; set; }

        //       private string imageString;
        public Image profileImage;
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


            //            string imgString = Convert.ToBase64String(UserInfo.UserImage);
            //            imageString = string.Format("img src=\"data:image/Bmp;base64,{0}\">", imgString);
            profileImage = Image.FromFile("../Coding_Coalition_Project_Final/Pages/Images/DefaultImage.jpg");
            return Page();

        }
    }
}
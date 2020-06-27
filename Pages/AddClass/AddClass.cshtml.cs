﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Razor.Tokenizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;

namespace Coding_Coalition_Project.Pages.AddClass
{
    public class AddClassModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AddClassModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

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

        [BindProperty]
        public Courses Courses { get; set; }

        [BindProperty]
        public UserInfo UserInfo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var Users = from m in _context.UserInfo select m;
            int UserID = (int)HttpContext.Session.GetInt32("UserID");
            Users = Users.Where(x => x.ID.Equals(UserID));
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Courses.Add(Courses);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}

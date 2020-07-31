using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;

namespace Coding_Coalition_Project.Pages.AddAnnouncements
{
    public class AddAnnouncementsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AddAnnouncementsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Announcements Announcements { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO
            Announcements.UserID = (int) HttpContext.Session.GetInt32("UserID");
            Announcements.CourseID = (int) HttpContext.Session.GetInt32("CourseID");

            _context.Announcements.Add(Announcements);
            await _context.SaveChangesAsync();

            return RedirectToPage("../MainPage/MainPage");
        }
    }
}

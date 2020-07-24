using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Pages.Announcements
{
    public class AnnouncementsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;
        public AnnouncementsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public Models.Announcements announcements{ get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            announcements = await _context.Announcements.FirstOrDefaultAsync(m => m.AnnouncementID == id);

            return Page();
        }
    }
}
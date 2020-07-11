using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Pages.Account
{
    public class AccountChargedModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AccountChargedModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public UserInfo UserInfo { get; set; }

        public string AmountMoney { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var id = HttpContext.Session.GetInt32("UserID");

            if (id == null)
            {
                return NotFound();
            }
            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

            int amountInt = (int) HttpContext.Session.GetInt32("AccountPayment");
            decimal result = amountInt / 100m;
            AmountMoney = result.ToString("c");

            return Page();
        }
    }
}
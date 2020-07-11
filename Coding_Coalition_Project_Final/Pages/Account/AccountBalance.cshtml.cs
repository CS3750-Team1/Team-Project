using System;
using System.Security.Policy;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Coding_Coalition_Project.Pages.AccountBalance
{
    public class AccountBalanceModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AccountBalanceModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public UserInfo UserInfo { get; set; }

        public int credit { get; set; }

        public decimal accountBalance { get; set; }

        public int AmountInt { get; set; }

        public string AmountMoney { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            var id = HttpContext.Session.GetInt32("UserID");

            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);
            credit = UserInfo.CreditHours;
            accountBalance = UserInfo.AccountCharges - UserInfo.AccountPayments;

            decimal result = accountBalance / 100m;
            AmountMoney = result.ToString("c");


            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {

            // TODO Need validation for input to make sure it comes in currency format "600.00"
            var amount = Request.Form["Amount"];

            double result = Double.Parse(amount) * 100;

            int finalAmount = (int)result;
            
            HttpContext.Session.SetInt32("AccountPayment", finalAmount);
            Console.WriteLine(HttpContext.Session.GetInt32("AccountPayment"));
            return RedirectToPage("../Account/AccountPayment");
        }

    }
}
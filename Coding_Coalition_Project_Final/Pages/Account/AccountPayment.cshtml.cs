using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stripe;

namespace Coding_Coalition_Project.Pages.AccountBalance
{
    public class AccountPaymentModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AccountPaymentModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public UserInfo UserInfo { get; set; }

        public int AmountInt { get; set; }

        public string AmountMoney { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            var id = HttpContext.Session.GetInt32("UserID");

            if (id == null)
            {
                return NotFound();
            }

            
            AmountInt = (int) HttpContext.Session.GetInt32("AccountPayment");
            decimal result = AmountInt / 100m;
            AmountMoney = result.ToString("c");
            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);



            return Page();
        }

        public ActionResult Index()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string stripeEmail, string stripeToken)
        {
            var id = HttpContext.Session.GetInt32("UserID");

            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

            var customers = new CustomerService();
            var charges = new ChargeService();
            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            
            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = (int) HttpContext.Session.GetInt32("AccountPayment"),
                Description = "Account Payment",
                Currency = "usd",
                Customer = customer.Id
            });
            

            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                
                var amount = (int)HttpContext.Session.GetInt32("AccountPayment");

                UserInfo.AccountPayments = amount + UserInfo.AccountPayments;
                _context.UserInfo.Update(UserInfo);
                await _context.SaveChangesAsync();

                return RedirectToPage("../Account/AccountCharged");
            }
            else
            {
                return Page();
            }
 
        }
    }
}
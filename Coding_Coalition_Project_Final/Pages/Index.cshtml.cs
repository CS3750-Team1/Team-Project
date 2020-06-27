using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Coding_Coalition_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string FirstName { get; set; }



        public void OnGet()
        {

                FirstName = HttpContext.Session.GetString("FirstName");
            
           
            if(string.IsNullOrWhiteSpace(FirstName))
            {
                FirstName = "";
            }
        }
    }
}

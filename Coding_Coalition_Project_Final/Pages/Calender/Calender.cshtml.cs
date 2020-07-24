using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;


namespace Coding_Coalition_Project.Pages.Calender
{
    public class Calender : PageModel
   {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public Calender(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        // GET api/events
         public IEnumerable<WebApiEvent> Get([FromQuery] DateTime from, [FromQuery] DateTime to)
        {
            return _context.Calender
                .ToList()
                .Select(e => (WebApiEvent)e);
        }

      
    }
}

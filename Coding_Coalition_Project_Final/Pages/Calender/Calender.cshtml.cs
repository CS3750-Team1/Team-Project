using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Web;

namespace Coding_Coalition_Project.Pages.Calender
{
    public class Calender : PageModel
   {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public Calender(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public UserInfo UserInfo { get; set; }

        public DateTime Date { get; set; }

        public List<Models.Calender> calenderList { get; set; }

        public string events { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            
            Date = DateTime.Now;
            var id = HttpContext.Session.GetInt32("UserID");
            
            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

            
            List<Models.Calender> tempCal = _context.Calender.ToList();

            List<string> tempList = new List<string>();

            string stringEvents = "";

            foreach (Models.Calender cal in tempCal)
            {
                if (UserInfo.ID == cal.UserID)
                {
                    /*
                    CalendarEvent calEvent = new CalendarEvent();
                    calEvent.title = cal.Name;
                    calEvent.start = cal.StartDate;

                    string result = JsonConvert.SerializeObject(calEvent);
                    tempList.Add(result);
                    */

                    stringEvents += "{ title: '" + cal.Name + "'";
                    stringEvents += " start: '" + cal.StartDate + "' }";

                }
            }

            events = HttpUtility.JavaScriptStringEncode(stringEvents);


            return Page();
        }
      
    }
}

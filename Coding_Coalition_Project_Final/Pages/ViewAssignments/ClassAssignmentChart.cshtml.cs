using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage;
using System.Web.Helpers;
namespace Coding_Coalition_Project.Pages.ViewAssignments
{
    public class ClassAssignmentChartModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public ClassAssignmentChartModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<SubmitAssignment> submitAssignment { get;set; }
        public IList<SubmitAssignment> classAssignment { get; set; }


        public int totalA = 0;
        public int totalB = 0;
        public int totalC = 0;
        public int totalD = 0;
        public int totalF = 0;

        public int returnAssignmentID()
        {
            return (int)HttpContext.Session.GetInt32("AssignmentID");
        }
        public async Task OnGetAsync()
        {
            submitAssignment = await _context.SubmitAssignments.ToListAsync();
            submitAssignment = submitAssignment.Where(x => x.AssignmentID == HttpContext.Session.GetInt32("AssignmentID")).ToList();

           foreach(SubmitAssignment item in submitAssignment)
            {

                if((double)item.Points / (double)item.maxPoints >= .9)
                {
                    totalA++;
                }
                else if((double)item.Points / (double)item.maxPoints >= .8)
                {
                    totalB++;
                }
                else if((double)item.Points / (double)item.maxPoints >= .7)
                {
                    totalC++;
                }
                else if((double)item.Points / (double)item.maxPoints >= .6)
                {
                    totalD++;
                }
                else
                {
                    totalF++;
                }
            }


        }
    }
}

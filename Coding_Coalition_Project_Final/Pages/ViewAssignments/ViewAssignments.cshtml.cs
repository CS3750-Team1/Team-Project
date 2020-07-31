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

namespace Coding_Coalition_Project.Pages.ViewAssignments
{
    public class ViewAssignmentsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public ViewAssignmentsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<Assignments> Assignments { get;set; }
        public int GetIsInstructor()
        {

            return (int)HttpContext.Session.GetInt32("IsInstructor");
        }
        public async Task OnGetAsync(int? id)
        {
            var tempAssignments = await _context.Assignments.ToListAsync();
            List<Assignments> tempList = new List<Assignments>();
            foreach (Assignments assign in tempAssignments)
            {
                if (assign.ClassID == HttpContext.Session.GetInt32("CourseID")) 
                {
                    tempList.Add(assign);
                }
            }
            Assignments = tempList;
        }
    }
}

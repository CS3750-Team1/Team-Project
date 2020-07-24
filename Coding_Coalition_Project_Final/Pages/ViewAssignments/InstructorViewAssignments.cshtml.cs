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
    public class InstructorViewAssignmentsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public InstructorViewAssignmentsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<SubmitAssignment> SubmitAssignment { get;set; }
        public IList<UserInfo> UserInfo { get; set; }
        public string getUserName(int id)
        {
            IList<UserInfo> temp = UserInfo;
            temp = temp.Where(x => x.ID == id).ToList();
            return temp.FirstOrDefault().FirstName + " " + temp.FirstOrDefault().LastName;
        }
        public async Task OnGetAsync(int? id)
        {

            SubmitAssignment = await _context.SubmitAssignments.ToListAsync();
            SubmitAssignment = SubmitAssignment.Where(x => x.AssignmentID == HttpContext.Session.GetInt32("AssignmentID")).ToList();
            UserInfo = _context.UserInfo.ToList();
        }
    }
}

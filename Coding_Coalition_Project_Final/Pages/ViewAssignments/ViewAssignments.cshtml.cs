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
        public IList<SubmitAssignment> submitAssignments { get; set; }
        public List<int> userPoints = new List<int>();
        public int totalPoints = 0;
        public int scoredPoints = 0;
        public int GetIsInstructor()
        {

            return (int)HttpContext.Session.GetInt32("IsInstructor");
        }
        public async Task OnGetAsync(int? id)
        {
            var tempAssignments = await _context.Assignments.ToListAsync();
            submitAssignments = await _context.SubmitAssignments.ToListAsync();
            submitAssignments = submitAssignments.Where(x => x.CourseID == HttpContext.Session.GetInt32("CourseID")).ToList();
            submitAssignments = submitAssignments.Where(x => x.UserID == HttpContext.Session.GetInt32("UserID")).OrderBy(x => x.AssignmentID).ToList();


            List<Assignments> tempList = new List<Assignments>();
            foreach (Assignments assign in tempAssignments)
            {
                if (assign.ClassID == HttpContext.Session.GetInt32("CourseID")) 
                {
                    tempList.Add(assign);
                }
            }
            Assignments = tempList;


            for (int i = 0; i < submitAssignments.Count(); i++)
            {
                userPoints.Add(submitAssignments[i].Points);
                totalPoints += submitAssignments[i].maxPoints;
                scoredPoints += submitAssignments[i].Points;
            }
            if (submitAssignments.Count() < tempList.Count())
            {
                for (int i = 0; i < tempList.Count() - submitAssignments.Count(); i++)
                {
                    userPoints.Add(0);
                }
            }
        }
    }
}

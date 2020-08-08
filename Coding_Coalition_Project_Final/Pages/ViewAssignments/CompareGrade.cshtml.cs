using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;

namespace Coding_Coalition_Project.Pages.ViewAssignments
{
    public class CompareGradeModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public CompareGradeModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public IList<SubmitAssignment> submitAssignment { get; set; }
        public int[] scoreArray;
        public int length = 8;
        public int min;
        public int q1;
        public int med;
        public int q3;
        public int max;

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            HttpContext.Session.SetInt32("AssignmentID", (int)id);
            submitAssignment = _context.SubmitAssignments.ToList();
      
          submitAssignment = submitAssignment.Where(x => x.AssignmentID == HttpContext.Session.GetInt32("AssignmentID")).ToList();
            scoreArray = new int[submitAssignment.Count()];

            

                    for(int i = 0; i < submitAssignment.Count(); i++)
                    {
                        scoreArray[i] = submitAssignment[i].Points;
                    }
            List<int> scoreList = scoreArray.ToList();
            List<int> boxPlotScores = SubmitAssignment.calulateBoxPlot(scoreList);

            min = boxPlotScores[0];
            q1 = boxPlotScores[1];
            med = boxPlotScores[2];
            q3 = boxPlotScores[3];
            max = boxPlotScores[4];

            if (submitAssignment == null)
            {
                return NotFound();
            }
                return Page();

        }
    }
}

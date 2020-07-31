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
using Microsoft.Graph;

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
               //       foreach(SubmitAssignment item in submitAssignment)
                 //     {
                   //       scoreArray.Append(item.Points);
                    //  }

            

                    for(int i = 0; i < submitAssignment.Count(); i++)
                    {
                        scoreArray[i] = submitAssignment[i].Points;
                    }



                      Console.WriteLine("Array Length" + scoreArray.Count());
            scoreArray = scoreArray.OrderBy(x => x).ToArray();
            List<int> lower = new List<int>();
            List<int> upper = new List<int>();

            if (scoreArray.Count() == 1)
            {
                min = scoreArray[0];
                q1 = scoreArray[0];
                med = scoreArray[0];
                q3 = scoreArray[0];
                max = scoreArray[0];
            }
            else if(scoreArray.Count() % 2 == 0)
            {

                int halfway = scoreArray.Count() / 2;
                for (int i = 0; i < scoreArray.Count(); i++)
                {
                    if (i < halfway)
                    {
                        lower.Add(scoreArray[i]);
                    }
                    else
                    {
                        upper.Add(scoreArray[i]);
                    }
                }

                min = lower[0];
                max = upper[upper.Count() - 1];
                med = (lower[lower.Count() - 1] + upper[0]) / 2;

            }
            else
            {
                int halfway = scoreArray.Count() / 2;
                for (int i = 0; i < scoreArray.Count(); i++)
                {
                    if (i < halfway)
                    {
                        lower.Add(scoreArray[i]);
                    }
                    else if(i == halfway)
                    {
                        med = scoreArray[i];
                    }
                    else{
                        upper.Add(scoreArray[i]);
                    }
                }

                min = scoreArray[0];
                max = scoreArray[scoreArray.Count() - 1];
            }
            if (lower.Count() % 2 == 0 && scoreArray.Count() != 1)
            {
                int halfway = lower.Count / 2;
                q1 = (lower[halfway - 1] + lower[halfway]) / 2;
                Console.WriteLine(upper.Count());
                q3 =  (upper[halfway - 1] + upper[halfway]) / 2;
            }
            else if(lower.Count() % 2 == 1 && scoreArray.Count() != 1)
            {
                int halfway = lower.Count / 2;
                q1 = lower[halfway];
                q3 = upper[halfway];
                Console.WriteLine(upper.Count());
                //q3 = 40;
            }

          
            if (submitAssignment == null)
            {
                return NotFound();
            }
                return Page();

        }
    }
}

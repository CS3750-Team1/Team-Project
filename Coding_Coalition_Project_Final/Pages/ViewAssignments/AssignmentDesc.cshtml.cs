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
using System.IO;
using System.Web.Mvc;
using System.Web;
using DHTMLX.Scheduler.Controls;

namespace Coding_Coalition_Project.Pages.ViewAssignments
{
    public class AssignmentDescModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public AssignmentDescModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        public Assignments Assignments { get; set; }
        [BindProperty]
        public string fileLocation { get; set; }
        public Assignments SAssignments;
        public SubmitAssignment submitAssignment = new SubmitAssignment();
        [BindProperty]
        public IFormFile uploadedFile { get; set; }

        public int AssignmentID;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HttpContext.Session.SetInt32("AssignmentID",(int)id);
            Assignments = await _context.Assignments.FirstOrDefaultAsync(m => m.AssignmentID == id);

            if (Assignments == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<RedirectToPageResult> OnPostAsync()
        {
            
              var AssignmentList = from m in _context.SubmitAssignments select m;

              AssignmentList = AssignmentList.Where(m => m.CourseID == HttpContext.Session.GetInt32("CourseID"));
            AssignmentList = AssignmentList.Where(m => m.AssignmentID == HttpContext.Session.GetInt32("AssignmentID"));
              AssignmentList = AssignmentList.Where(m => m.UserID == HttpContext.Session.GetInt32("UserID"));

            submitAssignment.UserID = (int)HttpContext.Session.GetInt32("UserID");
            submitAssignment.CourseID = (int)HttpContext.Session.GetInt32("CourseID");
            SAssignments = await _context.Assignments.FirstOrDefaultAsync(m => m.AssignmentID == HttpContext.Session.GetInt32("AssignmentID"));

            submitAssignment.AssignmentID = SAssignments.AssignmentID;
            submitAssignment.maxPoints = SAssignments.MaxPoints;
            submitAssignment.submissionType = SAssignments.submissionType;

            if (submitAssignment.submissionType == "file")
            {
                string filePath = "~/../Assignments/" + SAssignments.AssignmentName + "_" + HttpContext.Session.GetString("FirstName") +"_" + submitAssignment.CourseID + "_" + submitAssignment.AssignmentID + "_" + submitAssignment.UserID;
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    //await uploadedFile.CopyToAsync(fileStream);
                    uploadedFile.CopyTo(fileStream);
                }
                submitAssignment.AssignmentLocation = filePath;
            }
           else
            {
                submitAssignment.AssignmentLocation = fileLocation;
            }
   
            if (AssignmentList.Count() == 0)
            {
                _context.SubmitAssignments.Add(submitAssignment);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("./ViewAssignments");
        }
    }
}

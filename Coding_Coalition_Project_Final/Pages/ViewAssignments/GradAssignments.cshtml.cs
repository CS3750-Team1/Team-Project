using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Coding_Coalition_Project.Data;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Coding_Coalition_Project.Pages.ViewAssignments
{
    public class GradAssignmentsModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public GradAssignmentsModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SubmitAssignment SubmitAssignment { get; set; }
        public Assignments Assignment { get; set; }


        public string getAssignmentName()
        {
            Assignments assignments = _context.Assignments.First(x => x.AssignmentID == HttpContext.Session.GetInt32("AssignmentID"));
            return assignments.AssignmentName;
        }
        public string getAssignmentDescription()
        {
            Assignments assignments = _context.Assignments.First(x => x.AssignmentID == HttpContext.Session.GetInt32("AssignmentID"));
            return assignments.AssignmentDescription;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubmitAssignment = await _context.SubmitAssignments.FirstOrDefaultAsync(m => m.SAssignmentID == id);
            Assignment = _context.Assignments.First(m => m.ClassID == SubmitAssignment.CourseID);
            HttpContext.Session.SetInt32("SAssignmentID", (int)id);
            if (SubmitAssignment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostDownloadFile()
        {
            SubmitAssignment submitAssignment = _context.SubmitAssignments.First(x => x.SAssignmentID == HttpContext.Session.GetInt32("SAssignmentID"));
            //return File(submitAssignment.AssignmentLocation + ".FILE", submitAssignment.submissionType, submitAssignment.AssignmentLocation);
            var memory = new System.IO.MemoryStream();
            using (var stream = new FileStream(submitAssignment.AssignmentLocation, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, submitAssignment.submissionType, submitAssignment.AssignmentLocation);
        }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Attach(SubmitAssignment).State = EntityState.Modified;

            if(SubmitAssignment.Points < 0 || SubmitAssignment.Points > SubmitAssignment.maxPoints)
            {
                return null;
            }
            try
            {
                Models.Announcements announce = new Models.Announcements();
                announce.AnnouncementTitle = getAssignmentName() + " has been Graded";
                announce.UserID = SubmitAssignment.UserID;
                announce.AnnouncementText = getAssignmentName() + " has been Graded";
                announce.CourseID = SubmitAssignment.CourseID;
                _context.Announcements.Add(announce);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubmitAssignmentExists(SubmitAssignment.SAssignmentID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./InstructorViewAssignments");
        }

        private bool SubmitAssignmentExists(int id)
        {
            return _context.SubmitAssignments.Any(e => e.SAssignmentID == id);
        }
    }
}

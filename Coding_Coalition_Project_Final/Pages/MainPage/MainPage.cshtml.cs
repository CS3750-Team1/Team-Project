﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Coalition_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Coding_Coalition_Project.Pages.MainPage
{
    public class MainPageModel : PageModel
    {
        private readonly Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext _context;

        public MainPageModel(Coding_Coalition_Project.Data.Coding_Coalition_ProjectContext context)
        {
            _context = context;
        }

        /*
                [BindProperty]
                public UserInfo UserInfo { get; set; }

                [BindProperty]
                public UserJunctionCourses UserJunctionCourses { get; set; }

                [BindProperty]
                public Courses Courses { get; set; }

                [BindProperty]
                public Announcements Announcements { get; set; }
        */

        public UserInfo UserInfo { get; set; }

        public List<string> tempMenu = new List<string>(new string[] { "Account", "Classes", "Mail", "Settings", "Log Out" });

        public IList<Courses> userCourses { get; set; }

        public IList<Assignments> userAssignments { get; set; }

        public IList<Models.Announcements> userAnnouncements { get; set; }

        private int IsInstructor;

        public void SetIsInstructor(int temp)
        {
            IsInstructor = temp;
        }
        public int GetIsInstructor()
        {
            Console.WriteLine($"IsInstructor returned: " + IsInstructor.ToString());
            return IsInstructor;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var id = HttpContext.Session.GetInt32("UserID");

            if (id == null)
            {
                return NotFound();
            }

            UserInfo = await _context.UserInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (UserInfo.IsInstructor)
            {
                SetIsInstructor(1);
            } else
            {
                SetIsInstructor(0);
            }     

            List<UserJunctionCourses> courses = _context.UserJunctionCourses.ToList();
            List<Courses> uCourses = new List<Courses>();

            if (IsInstructor != 1)
            {
                foreach (UserJunctionCourses ujc in courses)
                {
                    if (ujc.UserID == UserInfo.ID)
                    {
                        Courses course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseID == ujc.CourseID);
                        uCourses.Add(course);
                    }
                }
            }
            else
            {
                List<Courses> icourse1 = _context.Courses.ToList();
                foreach (Courses icourse in icourse1)
                {
                    if (icourse.InstructorID == UserInfo.ID)
                    {
                        uCourses.Add(icourse);
                    }
                }

            }
            
            if (uCourses.Count == 0)
            {
                userCourses = new List<Courses>();
            }
                userCourses = uCourses;


            List<Assignments> assignments = _context.Assignments.ToList();
            List<Assignments> uAssignments = new List<Assignments>();
            if (assignments.Count != 0)
            {
                foreach (Assignments assignments1 in assignments)
                {
                    foreach (Courses courses1 in uCourses)
                    {
                        if (assignments1.ClassID == courses1.CourseID)
                        {
                            uAssignments.Add(assignments1);
                        }
                    }
                }

                var varAssignments = uAssignments.OrderBy(x => x.DueDate.Date);
                int ToDoListLimit = 0;
                List<Assignments> nextAssinments = new List<Assignments>();
                foreach (Assignments assignments2 in varAssignments)
                {
                    if (ToDoListLimit <= 4)
                    {
                        nextAssinments.Add(assignments2);
                        ToDoListLimit++;
                    }
                }

                userAssignments = nextAssinments;

            }
            else
            {
                userAssignments = new List<Assignments>();
            }


            List<Models.Announcements> allAnnouncements = _context.Announcements.ToList();
            allAnnouncements = allAnnouncements.OrderByDescending(x => x.AnnouncementID).ToList();
            userAnnouncements = new List<Models.Announcements>();
            List<Models.UserJunctionCourses> ujcList = _context.UserJunctionCourses.ToList();

            foreach (Models.Announcements announcement in allAnnouncements)
            {
                foreach (UserJunctionCourses ujc in ujcList) {
                    if (announcement.CourseID == ujc.CourseID && UserInfo.ID == ujc.UserID)
                    {
                        userAnnouncements.Add(announcement);
                    }
                }
                
            }


            return Page();
        }

    }
}
using Coding_Coalition_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public static class SchedulerSeeder
    {
        public static void Seed(Coding_Coalition_ProjectContext context)
        {
            if (context.Calender.Any())
            {
                return;   // DB has been seeded
            }

            var events = new List<Coding_Coalition_Project.Models.CalenderModel>()
            {
                new CalenderModel
                {
                    Name = "Assignment 1",
                    StartDate = new DateTime(2020, 7, 15, 2, 0, 0),
                    EndDate = new DateTime(2020, 7, 15, 4, 0, 0)
                },
                new CalenderModel()
                {
                    Name = "Assignment 2",
                    StartDate = new DateTime(2020, 7, 30, 3, 0, 0),
                    EndDate = new DateTime(2020, 7, 30, 6, 0, 0)
                },
                new CalenderModel()
                {
                    Name = "Assignment 3",
                    StartDate = new DateTime(2020, 8, 2, 0, 0, 0),
                    EndDate = new DateTime(2020, 8, 2, 0, 0, 0)
                }
            };

            events.ForEach(s => context.Calender.Add(s));
            context.SaveChanges();
        }
    }
}

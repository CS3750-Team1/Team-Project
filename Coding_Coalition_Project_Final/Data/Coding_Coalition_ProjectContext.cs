using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coding_Coalition_Project.Models;

namespace Coding_Coalition_Project.Data
{
    public class Coding_Coalition_ProjectContext : DbContext
    {
        public Coding_Coalition_ProjectContext (DbContextOptions<Coding_Coalition_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Coding_Coalition_Project.Models.UserInfo> UserInfo { get; set; }

        public DbSet<Coding_Coalition_Project.Models.Courses> Courses { get; set; }

        public DbSet<Coding_Coalition_Project.Models.Announcements> Announcements { get; set; }

        public DbSet<Coding_Coalition_Project.Models.AssignmentCodes> AssignmentCodes { get; set; }

        public DbSet<Coding_Coalition_Project.Models.Assignments> Assignments { get; set; }

        public DbSet<Coding_Coalition_Project.Models.UserJunctionCourses> UserJunctionCourses { get; set; }

        public DbSet<Coding_Coalition_Project.Models.CourseSubject> CourseSubject { get; set; }

        public DbSet<Coding_Coalition_Project.Models.CalenderModel> Calender { get; set; }
    }
}

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
    }
}

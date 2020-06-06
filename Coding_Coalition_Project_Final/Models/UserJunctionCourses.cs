using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class UserJunctionCourses
    {
        [Key]
        public int UserCourseID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
    }
}

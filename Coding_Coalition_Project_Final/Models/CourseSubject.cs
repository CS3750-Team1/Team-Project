using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class CourseSubject
    {
        [Key]
        public int CourseSubjectID { get; set; }

        [Required, RegularExpression(@"^['A-Za-z\s-]*")]
        public string CourseSubjectName { get; set; }

    }
}

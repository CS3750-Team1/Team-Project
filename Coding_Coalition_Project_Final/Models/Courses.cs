﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }


        [Required, RegularExpression(@"^['A-Za-z0-9-\s']*")]
        public string CourseName { get; set; }



        public int CourseSubject { get; set; }

        
        public int CourseNumber { get; set; }

        public int InstructorID { get; set; }


    }
}
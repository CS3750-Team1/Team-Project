﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class SubmitAssignment
    {
        [Key]
        public int SAssignmentID { get; set; }
        public int Points { get; set; }
        public int maxPoints { get; set; }
        public string submissionType { get; set; }
        public string AssignmentLocation { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int AssignmentID { get; set; }
    }
}
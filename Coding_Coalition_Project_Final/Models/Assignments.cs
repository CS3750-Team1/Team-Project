using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class Assignments
    {
        [Key]
        public int AssignmentID { get; set; }

        [Required]
        public string AssignmentName { get; set; }

        public int AssignmentCode { get; set; }
        public int ClassID { get; set; }
    
        [Required, DataType(DataType.DateTime)]
        public DateTime DueDate {get;set;}

        public int MaxPoints { get; set; }

    }
}

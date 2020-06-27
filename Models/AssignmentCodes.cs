using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class AssignmentCodes
    {
        [Key]
        public int AssignmentCodesID { get; set; }

        [Required, RegularExpression(@"^[A-Za-z-]*")]
        public string AssignmentCodeName { get; set; }
        

    }
}

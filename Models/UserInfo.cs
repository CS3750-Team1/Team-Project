using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }
        [Required, RegularExpression(@"^['A-Za-z-']*")]
        public string FirstName { get; set; }
        [Required, RegularExpression(@"^['A-Za-z-']*")]
        public string LastName { get; set; }
        [Display(Name = "Birthdate"), DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Required, RegularExpression(@"^['A-Za-z0-9-@._'-]*")]
        public string Email { get; set; }

        [RegularExpression(@"^['A-Za-z0-9""'\s-]*$"), DataType(DataType.Password)]
        public string Password { get; set; }

        public Byte[] UserImage { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Instructor")]
        public Boolean IsInstructor { get; set; }

        public string Biography { get; set; }

        public string Twitter { get; set; }

        public string Linkedin { get; set; }

        public string Facebook { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class SignInViewModel
    {

        public int ID { get; set; }

        [Required, RegularExpression(@"^['A-Za-z-@._'-]*")]
        public string Email { get; set; }

        [Required, RegularExpression(@"^['A-Za-z0-9""'\s-]*$"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

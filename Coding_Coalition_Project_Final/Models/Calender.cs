using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Coding_Coalition_Project.Migrations;

namespace Coding_Coalition_Project.Models
{
    [Table("Calender")]
    public class Calender
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static bool TestUserID(int userID)
        {
            return userID != 0;
        }

    }
}

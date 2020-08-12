using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class Announcements
    {
        [Key]
        public int AnnouncementID { get; set; }


        public int UserID { get; set; }

        public static bool TestUserID(int userID)
        {
            return userID != 0;
        }

        public int CourseID { get; set; }

        public static bool TestCourseID(int CourseID)
        {
            return CourseID != 0;
        }

        public string AnnouncementTitle { get; set; }
        public string AnnouncementText { get; set; }
    }
}

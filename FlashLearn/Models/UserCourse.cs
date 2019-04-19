using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLearn.Models
{
    public class UserCourse
    {
        public int UserID { get; set; }
        public int CourseID { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

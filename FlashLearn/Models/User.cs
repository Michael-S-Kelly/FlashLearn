using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLearn.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public ICollection<UserCourse> UserCourses { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLearn.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<UserCourse> UserCourse { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}

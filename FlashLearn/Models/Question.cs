using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLearn.Models
{
    public class Question
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public int QuestionLevel { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

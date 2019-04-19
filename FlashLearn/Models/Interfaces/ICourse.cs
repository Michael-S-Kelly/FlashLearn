using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLearn.Models.Interfaces
{
    public interface ICourse
    {
        Task AddCourse(Course course);

        Task<User> GetCourseByID(int id);

        Task<List<Course>> GetCourses();

        void RemoveCourse(int id);
    }
}

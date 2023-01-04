using api_base.Data;
using api_base.Models.Courses;

namespace api_base.Repositories.Courses
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(Context db) : base(db)
        {
        }
    }
}
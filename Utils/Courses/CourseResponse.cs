using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;

namespace api_base.Utils.Courses
{
    public class CourseResponse : Response<Course, CourseDto>
    {
        public CourseResponse(StatusCode code, string message, CourseDto dto) : base(code, message, dto)
        {
        }
    }
}
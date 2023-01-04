using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;
using api_base.Services.Courses;
using api_base.Utils.Courses;

namespace api_base.Handlers.Courses
{
    public class CourseUpdateHandler : UpdateHandler<Course, CourseDto, CourseInsertDto, CourseUpdateDto, CourseResponse>
    {
        public CourseUpdateHandler(ICourseService service) : base(service)
        {
        }
    }
}
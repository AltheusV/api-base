using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;
using api_base.Services.Courses;
using api_base.Utils;
using api_base.Utils.Courses;

namespace api_base.Handlers.Courses
{
    public class CourseCreateHandler : CreateHandler<Course, CourseDto, CourseInsertDto, CourseUpdateDto, CourseResponse>
    {
        public CourseCreateHandler(ICourseService service) : base(service) { }
    }
}
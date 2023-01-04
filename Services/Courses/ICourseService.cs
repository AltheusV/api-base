using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;

namespace api_base.Services.Courses
{
    public interface ICourseService : IService<Course, CourseDto, CourseInsertDto, CourseUpdateDto>
    {
        
    }
}
using api_base.Data.Dtos.Courses;
using api_base.Handlers.Courses;
using api_base.Models.Courses;
using api_base.Utils.Courses;

namespace api_base.Controllers.Courses
{
    public class CoursesController : Controller<Course, CourseDto, CourseInsertDto, CourseUpdateDto, CourseResponse>
    {
        public CoursesController(
            CourseReadHandler readHandler
            , CourseCreateHandler createHandler
            , CourseDeleteHandler deleteHandler
            , CourseUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        {
        }
    }
}
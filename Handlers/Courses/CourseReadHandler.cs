using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;
using api_base.Services.Courses;
using api_base.Utils;
using api_base.Utils.Courses;

namespace api_base.Handlers.Courses
{
    public class CourseReadHandler : ReadHandler<Course, CourseDto, CourseInsertDto, CourseUpdateDto, CourseResponse>
    {
        private readonly ICourseService service;

        public CourseReadHandler(ICourseService service) : base(service)
        {
            this.service = service;
        }

        public override async Task<Response<Course, CourseDto>> HandleAsync(int id)
        {
            var dto = await service.ReadAsync(id, customIncludes: s => s.Subjects);
            if (dto == default)
            {
                return CourseResponse.NotFound();
            }

            return CourseResponse.Success(dto: dto);
        }

        public override async Task<Response<Course, CourseDto>> HandleAsync()
        {
            var dtos = await service.ReadAsync(customIncludes: s => s.Subjects);

            if (dtos == default || dtos.Length == 0)
                return CourseResponse.NoContent();

            return CourseResponse.Success(dtos: dtos);
        }
    }
}
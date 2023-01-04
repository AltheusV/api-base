using AgileObjects.AgileMapper;
using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;
using api_base.Repositories.Courses;
using api_base.Repositories.Subjects;

namespace api_base.Services.Courses
{
    public class CourseService : Service<Course, CourseDto, CourseInsertDto, CourseUpdateDto>, ICourseService
    {
        private readonly ICourseRepository repository;
        private readonly ISubjectRepository subjectRepository;

        public CourseService(ICourseRepository repository, ISubjectRepository subjectRepository) : base(repository)
        {
            this.repository = repository;
            this.subjectRepository = subjectRepository;
        }

        public override async Task CreateAsync(CourseInsertDto insertDto)
        {
            var course = Mapper.Map(insertDto).ToANew<Course>();

            course.Subjects = await subjectRepository.GetAsync(insertDto.SubjectsIds, true);

            await repository.InsertAsync(course);
        }

        public override async Task UpdateAsync(CourseUpdateDto updateDto)
        {
            var course = await repository.GetAsync(updateDto.Id, true, customIncludes: c => c.Subjects);
            if (course == default)
                return;

            Mapper.Map(updateDto).Over(course);

            course.Subjects = await subjectRepository.GetAsync(updateDto.SubjectsIds, true);

            repository.Update(course);
        }
    }
}
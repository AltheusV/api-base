using AgileObjects.AgileMapper;
using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;
using api_base.Repositories.Courses;
using api_base.Repositories.Subjects;

namespace api_base.Services.Subjects
{
    public class SubjectService : Service<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto>, ISubjectService
    {
        private readonly ISubjectRepository repository;
        private readonly ICourseRepository courseRepository;

        public SubjectService(ISubjectRepository repository, ICourseRepository courseRepository) : base(repository)
        {
            this.repository = repository;
            this.courseRepository = courseRepository;
        }

        public override async Task CreateAsync(SubjectInsertDto insertDto)
        {
            var subject = Mapper.Map(insertDto).ToANew<Subject>();

            subject.Courses = await courseRepository.GetAsync(insertDto.CoursesIds, true);

            await repository.InsertAsync(subject);
        }

        public override async Task UpdateAsync(SubjectUpdateDto updateDto)
        {
            var subject = await repository.GetAsync(updateDto.Id, true, customIncludes: c => c.Courses);
            if (subject == default)
                return;

            Mapper.Map(updateDto).Over(subject);

            subject.Courses = await courseRepository.GetAsync(updateDto.CoursesIds, true);

            repository.Update(subject);
        }
    }
}
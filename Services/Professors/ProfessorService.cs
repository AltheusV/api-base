using AgileObjects.AgileMapper;
using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;
using api_base.Repositories.Courses;
using api_base.Repositories.Professors;
using api_base.Repositories.Subjects;

namespace api_base.Services.Professors
{
    public class ProfessorService : Service<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto>, IProfessorService
    {
        private readonly IProfessorRepository repository;
        private readonly ICourseRepository courseRepository;
        private readonly ISubjectRepository subjectRepository;

        public ProfessorService(
            IProfessorRepository repository
            , ICourseRepository courseRepository
            , ISubjectRepository subjectRepository) : base(repository)
        {
            this.repository = repository;
            this.courseRepository = courseRepository;
            this.subjectRepository = subjectRepository;
        }

        public override async Task CreateAsync(ProfessorInsertDto insertDto)
        {
            var professor = Mapper.Map(insertDto).ToANew<Professor>();

            professor.Subjects = await subjectRepository.GetAsync(insertDto.SubjectsIds, true);

            if (professor.CourseId.HasValue)
            {
                professor.Course = await courseRepository.GetAsync(professor.CourseId.Value, true);
            }

            await repository.InsertAsync(professor);
        }

        public override async Task UpdateAsync(ProfessorUpdateDto updateDto)
        {
            var professor = await repository.GetAsync(updateDto.Id, true, p => p.Course!, p => p.Subjects);
            if (professor == default)
                return;

            Mapper.Map(updateDto).Over(professor, cfg => cfg.Ignore(p => p.Course));

            professor.Subjects = await subjectRepository.GetAsync(updateDto.SubjectsIds, true);

            if (professor.CourseId.HasValue)
            {
                professor.Course = await courseRepository.GetAsync(professor.CourseId.Value, true);
            }

            repository.Update(professor);
        }
    }
}
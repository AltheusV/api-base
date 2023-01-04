using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;
using api_base.Services.Subjects;
using api_base.Utils;
using api_base.Utils.Subjects;

namespace api_base.Handlers.Subjects
{
    public class SubjectReadHandler : ReadHandler<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto, SubjectResponse>
    {
        private readonly ISubjectService service;

        public SubjectReadHandler(ISubjectService service) : base(service)
        {
            this.service = service;
        }

        public override async Task<Response<Subject, SubjectDto>> HandleAsync(int id)
        {
            var dto = await service.ReadAsync(id, customIncludes: s => s.Courses);
            if (dto == default)
            {
                return SubjectResponse.NotFound();
            }

            return SubjectResponse.Success(dto: dto);
        }

        public override async Task<Response<Subject, SubjectDto>> HandleAsync()
        {
            var dtos = await service.ReadAsync(customIncludes: s => s.Courses);

            if (dtos == default || dtos.Length == 0)
                return SubjectResponse.NoContent();

            return SubjectResponse.Success(dtos: dtos);
        }
    }
}
using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;
using api_base.Services.Subjects;
using api_base.Utils.Subjects;

namespace api_base.Handlers.Subjects
{
    public class SubjectCreateHandler : CreateHandler<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto, SubjectResponse>
    {
        public SubjectCreateHandler(ISubjectService service) : base(service)
        {
        }
    }
}
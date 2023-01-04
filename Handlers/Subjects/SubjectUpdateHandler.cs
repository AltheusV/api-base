using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;
using api_base.Services.Subjects;
using api_base.Utils.Subjects;

namespace api_base.Handlers.Subjects
{
    public class SubjectUpdateHandler : UpdateHandler<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto, SubjectResponse>
    {
        public SubjectUpdateHandler(ISubjectService service) : base(service)
        {
        }
    }
}
using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;
using api_base.Services.Subjects;
using api_base.Utils.Subjects;

namespace api_base.Handlers.Subjects
{
    public class SubjectDeleteHandler : DeleteHandler<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto, SubjectResponse>
    {
        public SubjectDeleteHandler(ISubjectService service) : base(service)
        {
        }
    }
}
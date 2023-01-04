using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;

namespace api_base.Utils.Subjects
{
    public class SubjectResponse : Response<Subject, SubjectDto>
    {
        public SubjectResponse(StatusCode code, string message, SubjectDto dto) : base(code, message, dto)
        {
        }
    }
}
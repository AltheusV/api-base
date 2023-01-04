using api_base.Data.Dtos.Subjects;
using api_base.Models.Subjects;

namespace api_base.Services.Subjects
{
    public interface ISubjectService : IService<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto>
    {
        
    }
}
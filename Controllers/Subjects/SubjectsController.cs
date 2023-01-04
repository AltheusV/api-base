using api_base.Data.Dtos.Subjects;
using api_base.Handlers.Subjects;
using api_base.Models.Subjects;
using api_base.Utils.Subjects;

namespace api_base.Controllers.Subjects
{
    public class SubjectsController : Controller<Subject, SubjectDto, SubjectInsertDto, SubjectUpdateDto, SubjectResponse>
    {
        public SubjectsController(
            SubjectReadHandler readHandler
            , SubjectCreateHandler createHandler
            , SubjectDeleteHandler deleteHandler
            , SubjectUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        {
        }
    }
}
using api_base.Data.Dtos.Professors;
using api_base.Handlers.Professors;
using api_base.Models.Professors;
using api_base.Utils.Professors;

namespace api_base.Controllers.Professors
{
    public class ProfessorsController : Controller<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto, ProfessorResponse>
    {
        public ProfessorsController(
            ProfessorReadHandler readHandler
            , ProfessorCreateHandler createHandler
            , ProfessorDeleteHandler deleteHandler
            , ProfessorUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        {
        }
    }
}
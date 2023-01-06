using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;
using api_base.Services.Professors;
using api_base.Utils.Professors;

namespace api_base.Handlers.Professors
{
    public class ProfessorUpdateHandler : UpdateHandler<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto, ProfessorResponse>
    {
        public ProfessorUpdateHandler(IProfessorService service) : base(service)
        {
        }
    }
}
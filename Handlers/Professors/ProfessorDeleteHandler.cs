using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;
using api_base.Services.Professors;
using api_base.Utils.Professors;

namespace api_base.Handlers.Professors
{
    public class ProfessorDeleteHandler : DeleteHandler<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto, ProfessorResponse>
    {
        public ProfessorDeleteHandler(IProfessorService service) : base(service)
        {
        }
    }
}
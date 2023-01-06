using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;
using api_base.Services.Professors;
using api_base.Utils.Professors;

namespace api_base.Handlers.Professors
{
    public class ProfessorCreateHandler : CreateHandler<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto, ProfessorResponse>
    {
        public ProfessorCreateHandler(IProfessorService service) : base(service)
        {
        }
    }
}
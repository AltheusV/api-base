using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;

namespace api_base.Utils.Professors
{
    public class ProfessorResponse : Response<Professor, ProfessorDto>
    {
        public ProfessorResponse(StatusCode code, string message, ProfessorDto dto) : base(code, message, dto)
        {
        }
    }
}
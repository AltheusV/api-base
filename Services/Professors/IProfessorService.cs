using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;

namespace api_base.Services.Professors
{
    public interface IProfessorService : IService<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto>
    {

    }
}
using api_base.Data.Dtos.Professors;
using api_base.Models.Professors;
using api_base.Services.Professors;
using api_base.Utils;
using api_base.Utils.Professors;

namespace api_base.Handlers.Professors
{
    public class ProfessorReadHandler : ReadHandler<Professor, ProfessorDto, ProfessorInsertDto, ProfessorUpdateDto, ProfessorResponse>
    {
        private readonly IProfessorService service;

        public ProfessorReadHandler(
            IProfessorService service) : base(service)
        {
            this.service = service;
        }

        public override async Task<Response<Professor, ProfessorDto>> HandleAsync(int id)
        {
            var dto = await service.ReadAsync(id, false, p => p.Card!, p => p.Course!, p => p.Subjects);
            if (dto == default)
            {
                return ProfessorResponse.NotFound();
            }

            return ProfessorResponse.Success(dto: dto);
        }

        public override async Task<Response<Professor, ProfessorDto>> HandleAsync()
        {
            var dtos = await service.ReadAsync(false, p => p.Card!, p => p.Course!, p => p.Subjects);

            if (dtos == default || dtos.Length == 0)
                return ProfessorResponse.NoContent();

            return ProfessorResponse.Success(dtos: dtos);
        }
    }
}
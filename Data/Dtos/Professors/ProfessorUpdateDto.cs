using System.ComponentModel.DataAnnotations;
using api_base.Models.Professors;

namespace api_base.Data.Dtos.Professors
{
    public class ProfessorUpdateDto : UpdateDto<Professor>
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; init; }

        public int? CourseId { get; init; }

        public int[] SubjectsIds { get; init; } = Array.Empty<int>();
    }
}
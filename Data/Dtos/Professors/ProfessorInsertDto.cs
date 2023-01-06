using System.ComponentModel.DataAnnotations;
using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Professors;

namespace api_base.Data.Dtos.Professors
{
    public class ProfessorInsertDto : InsertDto<Professor>
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; init; }

        [Required]
        public CardInsertDto? Card { get; init; }

        public int? CourseId { get; init; }

        public int[] SubjectsIds { get; init; } = Array.Empty<int>();
    }
}
using System.ComponentModel.DataAnnotations;
using api_base.Models.Courses;
using api_base.Models.Subjects;

namespace api_base.Data.Dtos.Subjects
{
    public class SubjectUpdateDto : UpdateDto<Subject>
    {
        [Required, MinLength(1)]
        public string? Name { get; init; }

        [Required, RegularExpression("([A-Z]{4})([0-9]{4})")]
        public string? Code { get; init; }

        [Required]
        public Hours? Hours { get; init; }

        [Required, MinLength(1), MaxLength(2)]
        public string? Group { get; init; }

        [Required]
        public int[] CoursesIds { get; init; } = Array.Empty<int>();
    }
}
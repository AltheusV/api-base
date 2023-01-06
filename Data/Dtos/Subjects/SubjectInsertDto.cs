using System.ComponentModel.DataAnnotations;
using api_base.Models.Courses;
using api_base.Models.Subjects;

namespace api_base.Data.Dtos.Subjects
{
    public class SubjectInsertDto : InsertDto<Subject>
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; init; }

        [Required, RegularExpression("([A-Z]{4})([0-9]{4})")]
        public string? Code { get; init; }

        [Required]
        public Hours? Hours { get; init; }

        [Required(AllowEmptyStrings = false), MaxLength(2)]
        public string? Group { get; init; }

        public int[] CoursesIds { get; init; } = Array.Empty<int>();

        public int[] ProfessorsIds { get; init; } = Array.Empty<int>();
    }
}
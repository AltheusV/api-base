using System.ComponentModel.DataAnnotations;
using api_base.Models.Courses;

namespace api_base.Data.Dtos.Courses
{
    public class CourseInsertDto : InsertDto<Course>
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; init; }

        [Required]
        public Shift Shift { get; init; }

        public int[] SubjectsIds { get; init; } = Array.Empty<int>();
    }
}
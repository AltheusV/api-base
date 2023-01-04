using System.ComponentModel.DataAnnotations;
using api_base.Models.Courses;

namespace api_base.Data.Dtos.Courses
{
    public class CourseUpdateDto : UpdateDto<Course>
    {
        [Required, MinLength(1)]
        public string? Name { get; init; }

        [Required]
        public Shift Shift { get; init; }

        [Required]
        public int[] SubjectsIds { get; init; } = Array.Empty<int>();
    }
}
using System.ComponentModel.DataAnnotations;
using api_base.Models.Courses;

namespace api_base.Models.Subjects
{
    public class Subject : Entity
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; set; }

        [Required, RegularExpression("([A-Z]{4})([0-9)]{4})")]
        public string? Code { get; set; }

        [Required]
        public Hours? Hours { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(2)]
        public string? Group { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
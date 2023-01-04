using System.ComponentModel.DataAnnotations;
using api_base.Models.Subjects;

namespace api_base.Models.Courses
{
    public class Course : Entity
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; set; }

        [Required]
        public Shift Shift { get; set; }

        //TODO Professors?
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
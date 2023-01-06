using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_base.Models.Courses;
using api_base.Models.Subjects;
using api_base.Models.Tags.Cards;

namespace api_base.Models.Professors
{
    public class Professor : Entity
    {
        [Required(AllowEmptyStrings = false)]
        public string? Name { get; set; }

        [Required]
        public int? CardId { get; set; }

        [ForeignKey("CardId")]
        public Card? Card { get; set; }

        private int? _courseId;
        public int? CourseId
        {
            get { return _courseId; }
            set { _courseId = value == 0 ? null : value; }
        }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
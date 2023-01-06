using api_base.Data.Dtos.Courses;
using api_base.Data.Dtos.Subjects;
using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Professors;

namespace api_base.Data.Dtos.Professors
{
    public class ProfessorDto : Dto<Professor>
    {
        public string? Name { get; set; }
        public int? CardId { get; set; }
        public CardDto? Card { get; set; }
        public int? CourseId { get; set; }
        public CourseDto? Course { get; set; }
        public ICollection<SubjectDto>? Subjects { get; set; }
    }
}
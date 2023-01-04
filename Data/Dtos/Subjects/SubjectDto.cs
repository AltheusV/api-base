using api_base.Data.Dtos.Courses;
using api_base.Models.Courses;
using api_base.Models.Subjects;

namespace api_base.Data.Dtos.Subjects
{
    public class SubjectDto : Dto<Subject>
    {
        public string? Name { get; set; }

        public string? Code { get; set; }

        public Hours? Hours { get; set; }

        public string? Group { get; set; }

        public ICollection<CourseDto>? Courses { get; set; }
    }
}
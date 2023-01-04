using api_base.Data.Dtos.Subjects;
using api_base.Models.Courses;

namespace api_base.Data.Dtos.Courses
{
    public class CourseDto : Dto<Course>
    {
        public string? Name { get; set; }

        public Shift Shift { get; set; }

        public ICollection<SubjectDto>? Subjects { get; set; }
    }
}
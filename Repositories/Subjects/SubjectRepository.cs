using api_base.Data;
using api_base.Models.Subjects;

namespace api_base.Repositories.Subjects
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(Context db) : base(db)
        {
        }
    }
}
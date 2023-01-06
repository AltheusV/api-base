using api_base.Data;
using api_base.Models.Professors;

namespace api_base.Repositories.Professors
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(Context db) : base(db)
        {
        }
    }
}
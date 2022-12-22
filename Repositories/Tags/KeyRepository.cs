using api_base.Data;
using api_base.Models.Tags;

namespace api_base.Repositories.Tags
{
    public class KeyRepository : Repository<Key>, IKeyRepository
    {
        public KeyRepository(Context db) : base(db) { }
    }
}
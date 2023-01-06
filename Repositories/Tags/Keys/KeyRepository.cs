using api_base.Data;
using api_base.Models.Tags.Keys;

namespace api_base.Repositories.Tags.Keys
{
    public class KeyRepository : Repository<Key>, IKeyRepository
    {
        public KeyRepository(Context db) : base(db) { }
    }
}
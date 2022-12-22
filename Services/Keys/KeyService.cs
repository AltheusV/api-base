using api_base.Data.Dtos.Keys;
using api_base.Models.Tags;
using api_base.Repositories.Tags;

namespace api_base.Services.Keys
{
    public class KeyService : Service<Key, KeyDto, KeyInsertDto, KeyUpdateDto>, IKeyService
    {
        public KeyService(IKeyRepository repository) : base(repository)
        {
        }
    }
}
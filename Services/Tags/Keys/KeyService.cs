using api_base.Data.Dtos.Tags.Keys;
using api_base.Models.Tags.Keys;
using api_base.Repositories.Tags.Keys;

namespace api_base.Services.Tags.Keys
{
    public class KeyService : Service<Key, KeyDto, KeyInsertDto, KeyUpdateDto>, IKeyService
    {
        public KeyService(IKeyRepository repository) : base(repository)
        {
        }
    }
}
using api_base.Data.Dtos.Tags.Keys;
using api_base.Models.Tags.Keys;
using api_base.Services.Tags.Keys;
using api_base.Utils.Tags.Keys;

namespace api_base.Handlers.Tags.Keys
{
    public class KeyUpdateHandler : UpdateHandler<Key, KeyDto, KeyInsertDto, KeyUpdateDto, KeyResponse>
    {
        public KeyUpdateHandler(IKeyService service) : base(service)
        {
        }
    }
}
using api_base.Data.Dtos.Keys;
using api_base.Models.Tags;
using api_base.Services.Keys;
using api_base.Utils.Keys;

namespace api_base.Handlers.Keys
{
    public class KeyUpdateHandler : UpdateHandler<Key, KeyDto, KeyInsertDto, KeyUpdateDto, KeyResponse>
    {
        public KeyUpdateHandler(IKeyService service) : base(service)
        {
        }
    }
}
using api_base.Data.Dtos.Tags.Keys;
using api_base.Models.Tags.Keys;

namespace api_base.Utils.Tags.Keys
{
    public class KeyResponse : Response<Key, KeyDto>
    {
        public KeyResponse(StatusCode code, string message, KeyDto dto) : base(code, message, dto)
        {
        }
    }
}
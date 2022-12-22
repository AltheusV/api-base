using api_base.Data.Dtos.Keys;
using api_base.Models.Tags;

namespace api_base.Utils.Keys
{
    public class KeyResponse : Response<Key, KeyDto>
    {
        public KeyResponse(StatusCode code, string message, KeyDto dto) : base(code, message, dto)
        {
        }
    }
}
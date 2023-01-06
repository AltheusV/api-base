using api_base.Models.Tags.Keys;

namespace api_base.Data.Dtos.Tags.Keys
{
    public class KeyDto : Dto<Key>
    {
        public Guid Uuid { get; set; }
    }
}
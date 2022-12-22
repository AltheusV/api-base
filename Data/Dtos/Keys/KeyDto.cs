using api_base.Models.Tags;

namespace api_base.Data.Dtos.Keys
{
    public class KeyDto : Dto<Key>
    {
        public Guid Uuid { get; set; }
    }
}
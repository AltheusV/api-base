using System.ComponentModel.DataAnnotations;
using api_base.Models.Tags.Keys;

namespace api_base.Data.Dtos.Tags.Keys
{
    public class KeyUpdateDto : UpdateDto<Key>
    {
        [Required]
        public Guid Uuid { get; init; }
    }
}
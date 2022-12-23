using System.ComponentModel.DataAnnotations;
using api_base.Models.Tags;

namespace api_base.Data.Dtos.Keys
{
    public class KeyUpdateDto : UpdateDto<Key>
    {
        [Required]
        public Guid Uuid { get; init; }
    }
}
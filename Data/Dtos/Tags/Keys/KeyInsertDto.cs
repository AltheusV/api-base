using System.ComponentModel.DataAnnotations;
using api_base.Models.Tags.Keys;

namespace api_base.Data.Dtos.Tags.Keys
{
    public class KeyInsertDto : InsertDto<Key>
    {
        [Required]
        public Guid Uuid { get; init; }
    }
}
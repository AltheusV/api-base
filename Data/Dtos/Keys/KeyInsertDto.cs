using System.ComponentModel.DataAnnotations;
using api_base.Models.Tags;

namespace api_base.Data.Dtos.Keys
{
    public class KeyInsertDto : InsertDto<Key>
    {
        [Required]
        public Guid Uuid { get; init; }
    }
}
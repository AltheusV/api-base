using System.ComponentModel.DataAnnotations;
using api_base.Models.Tags.Cards;

namespace api_base.Data.Dtos.Tags.Cards
{
    public class CardInsertDto : InsertDto<Card>
    {
        [Required]
        public Guid Uuid { get; init; }
    }
}
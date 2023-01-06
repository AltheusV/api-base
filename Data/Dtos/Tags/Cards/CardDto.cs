using api_base.Models.Tags.Cards;

namespace api_base.Data.Dtos.Tags.Cards
{
    public class CardDto : Dto<Card>
    {
        public Guid Uuid { get; set; }
    }
}
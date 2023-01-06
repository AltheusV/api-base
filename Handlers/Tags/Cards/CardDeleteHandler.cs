using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Tags.Cards;
using api_base.Services.Tags.Cards;
using api_base.Utils.Tags.Cards;

namespace api_base.Handlers.Tags.Cards
{
    public class CardDeleteHandler : DeleteHandler<Card, CardDto, CardInsertDto, CardUpdateDto, CardResponse>
    {
        public CardDeleteHandler(ICardService service) : base(service)
        {
        }
    }
}
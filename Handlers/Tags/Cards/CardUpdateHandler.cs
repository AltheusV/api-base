using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Tags.Cards;
using api_base.Services.Tags.Cards;
using api_base.Utils.Tags.Cards;

namespace api_base.Handlers.Tags.Cards
{
    public class CardUpdateHandler : UpdateHandler<Card, CardDto, CardInsertDto, CardUpdateDto, CardResponse>
    {
        public CardUpdateHandler(ICardService service) : base(service)
        {
        }
    }
}
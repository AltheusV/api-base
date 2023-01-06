using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Tags.Cards;
using api_base.Services.Tags.Cards;
using api_base.Utils.Tags.Cards;

namespace api_base.Handlers.Tags.Cards
{
    public class CardReadHandler : ReadHandler<Card, CardDto, CardInsertDto, CardUpdateDto, CardResponse>
    {
        public CardReadHandler(ICardService service) : base(service)
        {
        }
    }
}
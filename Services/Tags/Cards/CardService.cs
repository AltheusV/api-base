using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Tags.Cards;
using api_base.Repositories.Tags.Cards;

namespace api_base.Services.Tags.Cards
{
    public class CardService : Service<Card, CardDto, CardInsertDto, CardUpdateDto>, ICardService
    {
        public CardService(ICardRepository repository) : base(repository)
        {
        }
    }
}
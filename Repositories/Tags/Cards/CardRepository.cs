using api_base.Data;
using api_base.Models.Tags.Cards;

namespace api_base.Repositories.Tags.Cards
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        public CardRepository(Context db) : base(db)
        {
        }
    }
}
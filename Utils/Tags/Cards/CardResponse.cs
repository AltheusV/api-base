using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Tags.Cards;

namespace api_base.Utils.Tags.Cards
{
    public class CardResponse : Response<Card, CardDto>
    {
        public CardResponse(StatusCode code, string message, CardDto dto) : base(code, message, dto)
        {
        }
    }
}
using api_base.Data.Dtos.Tags.Cards;
using api_base.Models.Tags.Cards;

namespace api_base.Services.Tags.Cards
{
    public interface ICardService : IService<Card, CardDto, CardInsertDto, CardUpdateDto>
    {

    }
}
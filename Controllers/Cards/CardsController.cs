using api_base.Data.Dtos.Tags.Cards;
using api_base.Handlers.Tags.Cards;
using api_base.Models.Tags.Cards;
using api_base.Utils.Tags.Cards;
using Microsoft.AspNetCore.Mvc;

namespace api_base.Controllers.Cards
{
    public class CardsController : Controller<Card, CardDto, CardInsertDto, CardUpdateDto, CardResponse>
    {
        public CardsController(
            CardReadHandler readHandler
            , CardCreateHandler createHandler
            , CardDeleteHandler deleteHandler
            , CardUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        { }

        [NonAction]
        public override Task<ActionResult<CardResponse>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<CardResponse>> Get()
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<CardResponse>> Insert([FromBody] CardInsertDto dto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<CardResponse>> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
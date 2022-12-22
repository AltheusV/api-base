using api_base.Data.Dtos.Keys;
using api_base.Handlers.Keys;
using api_base.Models.Tags;
using api_base.Utils.Keys;
using Microsoft.AspNetCore.Mvc;

namespace api_base.Controllers.Keys
{
    public class KeysController : Controller<Key, KeyDto, KeyInsertDto, KeyUpdateDto, KeyResponse>
    {
        public KeysController(
            KeyReadHandler readHandler
            , KeyCreateHandler createHandler
            , KeyDeleteHandler deleteHandler
            , KeyUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        {

        }

        [NonAction]
        public override Task<ActionResult<KeyResponse>> Insert([FromBody] KeyInsertDto dto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<KeyResponse>> Update([FromBody] KeyUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<KeyResponse>> Delete(uint id)
        {
            throw new NotImplementedException();
        }
    }
}
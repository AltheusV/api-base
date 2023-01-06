using api_base.Data.Dtos.Tags.Keys;
using api_base.Handlers.Tags.Keys;
using api_base.Models.Tags.Keys;
using api_base.Utils.Tags.Keys;
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
        public override Task<ActionResult<KeyResponse>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<KeyResponse>> Get()
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<KeyResponse>> Insert([FromBody] KeyInsertDto dto)
        {
            throw new NotImplementedException();
        }

        [NonAction]
        public override Task<ActionResult<KeyResponse>> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
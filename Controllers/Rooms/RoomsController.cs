using api_base.Data.Dtos.Rooms;
using api_base.Handlers.Rooms;
using api_base.Models.Rooms;
using api_base.Utils.Rooms;
using Microsoft.AspNetCore.Mvc;

namespace api_base.Controllers.Rooms
{
    public class RoomsController : Controller<Room, RoomDto, RoomInsertDto, RoomUpdateDto, RoomResponse>
    {
        public RoomsController(
            RoomReadHandler readHandler
            , RoomCreateHandler createHandler
            , RoomDeleteHandler deleteHandler
            , RoomUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        {
        }

        [NonAction]
        public override Task<ActionResult<RoomResponse>> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
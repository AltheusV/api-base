using api_base.Data.Dtos.Rooms;
using api_base.Handlers.Rooms;
using api_base.Models.Rooms;
using api_base.Utils.Rooms;

namespace api_base.Controllers.Rooms
{
    public class RoomController : Controller<Room, RoomDto, RoomInsertDto, RoomUpdateDto, RoomResponse>
    {
        public RoomController(
            RoomReadHandler readHandler
            , RoomCreateHandler createHandler
            , RoomDeleteHandler deleteHandler
            , RoomUpdateHandler updateHandler) : base(readHandler, createHandler, deleteHandler, updateHandler)
        {
        }
    }
}
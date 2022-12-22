using api_base.Data.Dtos.Rooms;
using api_base.Models.Rooms;
using api_base.Services.Rooms;
using api_base.Utils.Rooms;

namespace api_base.Handlers.Rooms
{
    public class RoomUpdateHandler : UpdateHandler<Room, RoomDto, RoomInsertDto, RoomUpdateDto, RoomResponse>
    {
        public RoomUpdateHandler(IRoomService service) : base(service)
        {
        }
    }
}
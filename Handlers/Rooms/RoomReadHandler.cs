using api_base.Data.Dtos.Rooms;
using api_base.Models.Rooms;
using api_base.Services.Rooms;
using api_base.Utils.Rooms;

namespace api_base.Handlers.Rooms
{
    public class RoomReadHandler : ReadHandler<Room, RoomDto, RoomInsertDto, RoomUpdateDto, RoomResponse>
    {
        public RoomReadHandler(IRoomService service) : base(service)
        {
        }
    }
}
using api_base.Data.Dtos.Rooms;
using api_base.Models.Rooms;

namespace api_base.Utils.Rooms
{
    public class RoomResponse : Response<Room, RoomDto>
    {
        public RoomResponse(StatusCode code, string message, RoomDto dto) : base(code, message, dto)
        {
        }
    }
}
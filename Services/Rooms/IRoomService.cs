using api_base.Data.Dtos.Rooms;
using api_base.Models.Rooms;

namespace api_base.Services.Rooms
{
    public interface IRoomService : IService<Room, RoomDto, RoomInsertDto, RoomUpdateDto>
    {

    }
}
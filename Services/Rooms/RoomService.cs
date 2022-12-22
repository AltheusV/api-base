using api_base.Data.Dtos.Rooms;
using api_base.Models.Rooms;
using api_base.Repositories.Rooms;

namespace api_base.Services.Rooms
{
    public class RoomService : Service<Room, RoomDto, RoomInsertDto, RoomUpdateDto>, IRoomService
    {
        public RoomService(IRoomRepository repository) : base(repository)
        {
        }
    }
}
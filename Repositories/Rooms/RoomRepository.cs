using api_base.Data;
using api_base.Models.Rooms;

namespace api_base.Repositories.Rooms
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(Context db) : base(db) { }
    }
}
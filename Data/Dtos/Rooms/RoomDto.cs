using api_base.Data.Dtos.Keys;
using api_base.Models.Rooms;

namespace api_base.Data.Dtos.Rooms
{
    public class RoomDto : Dto<Room>
    {
        public string? Name { get; set; }

        public Block Block { get; set; }

        public bool? IsAcessible { get; set; }

        public bool? HasAirConditioner { get; set; }

        public bool? HasFan { get; set; }

        public bool? HasProjector { get; set; }

        public ushort? Capacity { get; set; }

        public int? KeyId { get; set; }

        public KeyDto? Key { get; set; }

        public bool Available { get; set; }

        public string? Note { get; set; }
    }
}
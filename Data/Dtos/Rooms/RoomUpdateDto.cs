using api_base.Models.Rooms;

namespace api_base.Data.Dtos.Rooms
{
    public class RoomUpdateDto : UpdateDto<Room>
    {
        public string? Name { get; init; }

        public Block Block { get; init; }

        public bool? IsAcessible { get; init; }

        public bool? HasAirConditioner { get; init; }

        public bool? HasFan { get; init; }

        public bool? HasProjector { get; init; }

        public ushort? Capacity { get; init; }

        public bool? Available { get; init; }

        public string? Note { get; init; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using api_base.Models.Rooms;
using api_base.Models.Tags;

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

        public uint? KeyId { get; set; }

        [ForeignKey("KeyId")]
        public Key? Key { get; set; }

        public bool Available { get; set; }

        public string? Note { get; set; }
    }
}
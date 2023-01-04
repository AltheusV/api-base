using System.ComponentModel.DataAnnotations;
using api_base.Models.Rooms;

namespace api_base.Data.Dtos.Rooms
{
    public class RoomUpdateDto : UpdateDto<Room>
    {
        [Required]
        public string? Name { get; init; }

        [Required]
        public Block Block { get; init; }

        [Required]
        public bool? IsAcessible { get; init; }

        [Required]
        public bool? HasAirConditioner { get; init; }

        [Required]
        public bool? HasFan { get; init; }

        [Required]
        public bool? HasProjector { get; init; }

        [Required]
        public ushort? Capacity { get; init; }

        [Required]
        public bool? Available { get; init; }

        [Required]
        public string? Note { get; init; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_base.Models.Tags;

namespace api_base.Models.Rooms
{
    public class Room : Entity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public Block Block { get; set; }

        [Required]
        public bool? IsAcessible { get; set; }

        [Required]
        public bool? HasAirConditioner { get; set; }

        [Required]
        public bool? HasFan { get; set; }

        [Required]
        public bool? HasProjector { get; set; }

        [Required]
        public ushort? Capacity { get; set; }

        [Required]
        public int? KeyId { get; set; }

        [ForeignKey("KeyId")]
        public Key? Key { get; set; }

        public bool Available { get; set; } = true;

        public string Note { get; set; } = string.Empty;
    }
}
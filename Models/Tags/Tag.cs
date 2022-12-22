using System.ComponentModel.DataAnnotations;

namespace api_base.Models.Tags
{
    public class Tag : Entity
    {
        [Required]
        public Guid Uuid { get; set; }
    }
}
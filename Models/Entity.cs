using System.ComponentModel.DataAnnotations;

namespace api_base.Models
{
    public abstract class Entity
    {
        [Key]
        public uint Id { get; set; }
    }
}
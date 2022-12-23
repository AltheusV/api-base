using System.ComponentModel.DataAnnotations;

namespace api_base.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using api_base.Models;

namespace api_base.Data.Dtos
{
    public abstract class UpdateDto<T> where T : Entity
    {
        [Required]
        public uint Id { get; init; }
    }
}
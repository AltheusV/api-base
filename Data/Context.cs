using api_base.Models.Rooms;
using api_base.Models.Tags;
using Microsoft.EntityFrameworkCore;

namespace api_base.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            // dotnet ef migrations add .. 
            // dotnet ef database update
        }
        
        public DbSet<Key>? Keys { get; set; }
        public DbSet<Room>? Rooms { get; set; }
    }
}
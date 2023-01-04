using api_base.Models.Courses;
using api_base.Models.Rooms;
using api_base.Models.Subjects;
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
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Subject>? Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Course>()
                .HasMany(p => p.Subjects)
                .WithMany(p => p.Courses)
                .UsingEntity(j => j.ToTable("course_subjects"));
        }
    }
}
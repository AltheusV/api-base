using api_base.Models.Courses;
using api_base.Models.Professors;
using api_base.Models.Rooms;
using api_base.Models.Subjects;
using api_base.Models.Tags.Cards;
using api_base.Models.Tags.Keys;
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
        public DbSet<Card>? Cards { get; set; }
        public DbSet<Professor>? Professors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Course>()
                .HasMany(c => c.Subjects)
                .WithMany(s => s.Courses)
                .UsingEntity(j => j.ToTable("course_subjects"));

            modelBuilder
                .Entity<Professor>()
                .HasMany(p => p.Subjects)
                .WithMany(s => s.Professors)
                .UsingEntity(j => j.ToTable("professor_subjects"));
        }
    }
}
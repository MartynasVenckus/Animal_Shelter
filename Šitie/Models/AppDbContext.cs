using Microsoft.EntityFrameworkCore;

namespace Šitie.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Vardenis", Surname = "Pavardenis", 
                    Email = "vardenis.pvardenis@gmail.com", Password = "123456", IsAdmin = true},
                new User { Id = 2, Name = "Domas", Surname = "Domaitis", 
                    Email = "domas@gmail.com", Password = "asdfasfsafas", IsAdmin = false},
                new User { Id = 3, Name = "Lukas", Surname = "Lukaitis", 
                    Email = "lukas.lukaitis@gmail.com", Password = "12345678", IsAdmin = false}
                );
        }
    }
}

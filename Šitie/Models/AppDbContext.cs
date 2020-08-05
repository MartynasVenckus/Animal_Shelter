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
    }
}

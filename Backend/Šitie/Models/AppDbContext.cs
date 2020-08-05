using Microsoft.EntityFrameworkCore;
using System;
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
            modelBuilder.Entity<Animal>().HasData(
                new Animal { Id = 1, ArivalDate = DateTime.Now.AddDays(-10), ChipDate = DateTime.Now.AddDays(-50),
                    VaccineDate = DateTime.MinValue, ArrivedFrom = "Kaunas", Type = AnimalType.Dog, 
                    Gender = Gender.Male, BornDate = new DateTime(2001, 1, 1), FurType = FurType.Roughhair,
                    FurColor = "Rudas su juodais taškeliais", Description = "Labai jautrus", HealthCondition = "Sveikas, trūksta 1 kojos",
                    OrganizationData = "Katino svajonė \n Partizanų g. 15, Kaunas 50203 \n (8-655) 15024",
                    Status = AnimalStatus.Shelter, DepartureDate = DateTime.MinValue},
                new Animal { Id = 2, ArivalDate = DateTime.Now.AddDays(-100), ChipDate = DateTime.Now.AddDays(-10),
                    VaccineDate = DateTime.Now.AddYears(-5), ArrivedFrom = "Vilnius", Type = AnimalType.Cat, 
                    Gender = Gender.Female, BornDate = new DateTime(2011, 1, 1), FurType = FurType.Mediumhair,
                    FurColor = "Juoda baltomis letenėlėmis", Description = "Labai miela, reikalauja dėmesio", 
                    HealthCondition = "Sveika, alergiška šunims",
                    OrganizationData = "Katino svajonė \n Partizanų g. 15, Kaunas 50203 \n (8-655) 15024",
                    Status = AnimalStatus.Shelter, DepartureDate = DateTime.MinValue},
                new Animal { Id = 3, ArivalDate = DateTime.Now.AddDays(-50), ChipDate = DateTime.MinValue,
                    VaccineDate = DateTime.MinValue, ArrivedFrom = "Klaipėda", Type = AnimalType.Other, 
                    Gender = Gender.Male, BornDate = new DateTime(2011, 1, 1), FurType = FurType.Roughhair,
                    FurColor = "Žalsvai pilkas", Description = "Driežas", 
                    HealthCondition = "Sveikas",
                    OrganizationData = "Katino svajonė \n Partizanų g. 15, Kaunas 50203 \n (8-655) 15024",
                    Status = AnimalStatus.Shelter, DepartureDate = DateTime.MinValue},
                new Animal { Id = 4, ArivalDate = DateTime.Now.AddDays(-100), ChipDate = DateTime.Now.AddDays(-50),
                    VaccineDate = DateTime.MinValue, ArrivedFrom = "Kaunas", Type = AnimalType.Cat, 
                    Gender = Gender.Male, BornDate = new DateTime(2001, 1, 1), FurType = FurType.Shorthair,
                    FurColor = "Ruda", Description = "-", HealthCondition = "Labai ligotas",
                    OrganizationData = "Katino svajonė \n Partizanų g. 15, Kaunas 50203 \n (8-655) 15024",
                    Status = AnimalStatus.Dead, DepartureDate = DateTime.Now.AddDays(-1)},
                new Animal { Id = 5, ArivalDate = DateTime.Now.AddDays(-100), ChipDate = DateTime.Now.AddDays(-50),
                    VaccineDate = DateTime.MinValue, ArrivedFrom = "Kaunas", Type = AnimalType.Cat, 
                    Gender = Gender.Male, BornDate = new DateTime(2001, 1, 1), FurType = FurType.Shorthair,
                    FurColor = "Ruda", Description = "-", HealthCondition = "Truputi ligotas",
                    OrganizationData = "Katino svajonė \n Partizanų g. 15, Kaunas 50203 \n (8-655) 15024",
                    Status = AnimalStatus.Adopted, DepartureDate = DateTime.Now.AddDays(-2)},
                new Animal { Id = 6, ArivalDate = DateTime.Now.AddDays(-100), ChipDate = DateTime.Now.AddDays(-50),
                    VaccineDate = DateTime.MinValue, ArrivedFrom = "Kaunas", Type = AnimalType.Cat, 
                    Gender = Gender.Female, BornDate = new DateTime(2001, 1, 1), FurType = FurType.Shorthair,
                    FurColor = "Ruda", Description = "-", HealthCondition = "Puiki",
                    OrganizationData = "Katino svajonė \n Partizanų g. 15, Kaunas 50203 \n (8-655) 15024",
                    Status = AnimalStatus.Adopted, DepartureDate = DateTime.Now.AddDays(-10)}
                );
        }
    }
}

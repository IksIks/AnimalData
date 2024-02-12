using AnimalData.Connection;
using AnimalData.DBContext.ConfigurationDB;
using AnimalData.Model.BaseClass;
using Microsoft.EntityFrameworkCore;

namespace AnimalData.DBContext
{
    internal class AnimalDBContext : DbContext
    {
        public AnimalDBContext()
        {
            Database.EnsureCreated();
        }

        public AnimalDBContext(DbContextOptions<AnimalDBContext> options) : base(options)
        {
        }

        public virtual DbSet<TableAnimal> TableAnimals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql(ConnectString.GetConnectionString());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //new TableAnimalConfig().Configure(modelBuilder.Entity<TableAnimal>());
            modelBuilder.ApplyConfiguration(new TableAnimalConfig());
            modelBuilder.Entity<TableAnimal>().HasData
                (
                    new TableAnimal(1, "Слон", 100, 2000),
                    new(2, "Голубь", 10, 1)
                );
        }
    }
}
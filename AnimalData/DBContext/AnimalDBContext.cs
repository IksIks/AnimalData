using AnimalData.Connection;
using AnimalData.Connection.ConfigurationDB;
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
            new TableAnimalConfig().Configure(modelBuilder.Entity<TableAnimal>());
        }
    }
}
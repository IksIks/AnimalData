using AnimalData.ConfigurationDB;
using AnimalData.Connection;
using AnimalData.Model;
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

        public virtual DbSet<Amphibian> Amphibians { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<Mammal> Mammals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql(ConnectString.GetConnectionString());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ChordalTypeConfig().Configure(modelBuilder.Entity<ChordalType>());
        }
    }
}
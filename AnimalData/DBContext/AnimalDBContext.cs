using AnimalData.Model;
using Microsoft.EntityFrameworkCore;

namespace AnimalData.DBContext
{
    internal class AnimalDBContext : DbContext
    {
        public AnimalDBContext()
        {
        }

        public AnimalDBContext(DbContextOptions<AnimalDBContext> options) : base(options)
        {
        }

        public virtual DbSet<ChordalType> ChordalClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql("Host=localhost;UserName=postgres;Password=1;Database=TestAnimal");
    }

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
}
using AnimalData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalData.ConfigurationDB
{
    internal class ChordalTypeConfig : IEntityTypeConfiguration<ChordalType>
    {
        public void Configure(EntityTypeBuilder<ChordalType> builder)
        {
            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.AnimalName).IsRequired().HasColumnName("name");
            builder.Property(a => a.LifeExpectancy).IsRequired();
            builder.Property(a => a.Weight).IsRequired();
        }
    }
}
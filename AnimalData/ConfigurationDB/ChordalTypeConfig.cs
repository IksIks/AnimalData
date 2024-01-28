using AnimalData.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AnimalData.ConfigurationDB
{
    internal class ChordalTypeConfig : IEntityTypeConfiguration<ChordalType>
    {
        public void Configure(EntityTypeBuilder<ChordalType> builder)
        {
            builder.Property(a => a.Id).IsRequired().HasColumnName("id");
            builder.Property(a => a.AnimalName).IsRequired().HasColumnName("animal_name");
            builder.Property(a => a.LifeExpectancy).IsRequired().HasColumnName("life_expectancy");
            builder.Property(a => a.Weight).IsRequired().HasColumnName("weight");
        }
    }
}
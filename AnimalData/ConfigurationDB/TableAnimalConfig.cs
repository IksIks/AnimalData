using AnimalData.Model.BaseClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalData.ConfigurationDB
{
    internal class TableAnimalConfig : IEntityTypeConfiguration<TableAnimal>
    {
        public void Configure(EntityTypeBuilder<TableAnimal> builder)
        {
            builder.Property(a => a.Id).IsRequired().HasColumnName("id");
            builder.Property(a => a.AnimalName).IsRequired().HasColumnName("animal_name");
            builder.Property(a => a.LifeExpectancy).IsRequired().HasColumnName("life_expectancy");
            builder.Property(a => a.Weight).IsRequired().HasColumnName("weight");
        }
    }
}
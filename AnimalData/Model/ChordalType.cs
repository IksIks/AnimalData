using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalData.Model
{
    [Table("animals")]
    internal abstract class ChordalType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("animal_name")]
        public string AnimalName { get; set; }

        [Column("life_expectancy")]
        public byte LifeExpectancy { get; set; }

        [Column("weight")]
        public int Weight { get; set; }
    }
}
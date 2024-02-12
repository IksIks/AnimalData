namespace AnimalData.Model.BaseClass
{
    internal abstract class ChordalType
    {
        public int Id { get; set; }

        public string? AnimalName { get; set; }

        public byte LifeExpectancy { get; set; }

        public double Weight { get; set; }

        public string AnimalType { get; set; }

        public ChordalType(int id, string animalName, byte lifeExpectancy, double weight, string animalType)
        {
            Id = id;
            AnimalName = animalName;
            LifeExpectancy = lifeExpectancy;
            Weight = weight;
            AnimalType = animalType;
        }
    }
}
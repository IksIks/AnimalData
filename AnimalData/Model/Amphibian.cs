using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Amphibian : TableAnimal
    {
        public Amphibian(int id, string animalName, byte lifeExpectancy, int weight, string animalType) : base(id, animalName, lifeExpectancy, weight, animalType)
        {
        }
    }
}
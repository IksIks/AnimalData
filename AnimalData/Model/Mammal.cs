using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Mammal : TableAnimal
    {
        public Mammal(int id, string animalName, byte lifeExpectancy, int weight, string animalType) : base(id, animalName, lifeExpectancy, weight, animalType)
        {
        }
    }
}
using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Mammal : TableAnimal
    {
        public Mammal(string animalName, byte lifeExpectancy, int weight) : base(animalName, lifeExpectancy, weight)
        {
        }
    }
}
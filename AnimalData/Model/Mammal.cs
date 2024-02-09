using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Mammal : TableAnimal
    {
        public Mammal(int id, string animalName, byte lifeExpectancy, int weight) : base(id, animalName, lifeExpectancy, weight)
        {
        }
    }
}
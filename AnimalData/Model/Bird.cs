using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Bird : TableAnimal
    {
        public Bird(int id, string animalName, byte lifeExpectancy, int weight) : base(id, animalName, lifeExpectancy, weight)
        {
        }
    }
}
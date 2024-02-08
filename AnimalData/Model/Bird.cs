using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Bird : TableAnimal
    {
        public Bird(string animalName, byte lifeExpectancy, int weight) : base(animalName, lifeExpectancy, weight)
        {
        }
    }
}
using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class Amphibian : TableAnimal
    {
        public Amphibian(string animalName, byte lifeExpectancy, int weight) : base(animalName, lifeExpectancy, weight)
        {
        }
    }
}
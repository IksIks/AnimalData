using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class UknowAnimal : TableAnimal
    {
        public UknowAnimal(string animalName, byte lifeExpectancy, int weight) : base(animalName, lifeExpectancy, weight)
        {
        }
    }
}
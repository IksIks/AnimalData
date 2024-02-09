using AnimalData.Model.BaseClass;

namespace AnimalData.Model
{
    internal class UknowAnimal : TableAnimal
    {
        public UknowAnimal(int id, string animalName, byte lifeExpectancy, int weight) : base(id, animalName, lifeExpectancy, weight)
        {
        }
    }
}
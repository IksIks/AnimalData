using AnimalData.Model;
using AnimalData.Model.BaseClass;

namespace AnimalData.Factory
{
    internal class AnimalFactory
    {
        public ChordalType GetNewAnimal(string animalType, string animalName, byte lifeExpectancy, int weight, int id = 0)
        {
            switch (animalType)
            {
                case "Млекопитающие":
                    {
                        return new Mammal(id, animalName, lifeExpectancy, weight);
                    }
                case "Птицы":
                    {
                        return new Bird(id, animalName, lifeExpectancy, weight);
                    }
                case "Земноводные":
                    {
                        return new Amphibian(id, animalName, lifeExpectancy, weight);
                    }
                default:
                    {
                        return new UknowAnimal(id, animalName, lifeExpectancy, weight);
                    }
            }
        }
    }
}
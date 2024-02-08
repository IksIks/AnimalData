using AnimalData.Model;
using AnimalData.Model.BaseClass;

namespace AnimalData.Factory
{
    internal class AnimalFactory
    {
        public ChordalType GetNewAnimal(string animalType, string animalName, byte lifeExpectancy, int weight)
        {
            switch (animalType)
            {
                case "Млекопитающие":
                    {
                        return new Mammal(animalName, lifeExpectancy, weight);
                    }
                case "Птицы":
                    {
                        return new Bird(animalName, lifeExpectancy, weight);
                    }
                case "Земноводные":
                    {
                        return new Amphibian(animalName, lifeExpectancy, weight);
                    }
                default:
                    {
                        return new UknowAnimal(animalName, lifeExpectancy, weight);
                    }
            }
        }
    }
}
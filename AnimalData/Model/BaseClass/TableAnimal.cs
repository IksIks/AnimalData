namespace AnimalData.Model.BaseClass
{
    internal class TableAnimal : ChordalType
    {
        public TableAnimal(int id, string animalName, byte lifeExpectancy, double weight, string animalType) : base(id, animalName, lifeExpectancy, weight, animalType)
        {
        }
    }
}
namespace AnimalData.Model.BaseClass
{
    internal class TableAnimal : ChordalType
    {
        public TableAnimal(int id, string animalName, byte lifeExpectancy, int weight) : base(id, animalName, lifeExpectancy, weight)
        {
        }
    }
}
namespace AnimalData.Model.BaseClass
{
    internal class TableAnimal : ChordalType
    {
        public TableAnimal(string animalName, byte lifeExpectancy, int weight) : base(animalName, lifeExpectancy, weight)
        {
        }
    }
}
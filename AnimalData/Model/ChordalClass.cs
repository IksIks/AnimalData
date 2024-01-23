namespace AnimalData.Model
{
    internal abstract class ChordalClass
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public byte LifeExpectancy { get; set; }
        public int Weight { get; set; }
    }
}
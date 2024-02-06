namespace AnimalData.Model.BaseClass
{
    internal abstract class ChordalType
    {
        public int Id { get; set; }

        public string? AnimalName { get; set; }

        public byte LifeExpectancy { get; set; }

        public int Weight { get; set; }
    }
}
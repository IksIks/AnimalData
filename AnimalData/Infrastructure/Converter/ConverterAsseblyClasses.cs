using AnimalData.Model.BaseClass;

namespace AnimalData.Infrastructure.Converter
{
    internal class ConverterAsseblyClasses
    {
        public ConverterAsseblyClasses()
        {
            var assemblyClasses = GetAssemblyAnimalsClases();
        }

        private ICollection<ChordalType?> GetAssemblyAnimalsClases()
        {
            return typeof(ChordalType)
                        .Assembly.GetTypes()
                        .Where(t => t.IsSubclassOf(typeof(ChordalType)) && !t.IsAbstract)
                        .Select(t => (ChordalType?)Activator.CreateInstance(t)).ToList();
        }
    }
}
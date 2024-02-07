using AnimalData.DBContext;
using AnimalData.Model.BaseClass;

namespace AnimalData.DBdataProvider
{
    internal class DBProvider
    {
        private AnimalDBContext animalDBContext = new();

        public DBProvider()
        {
        }

        public async Task<ICollection<TableAnimal>> GetDataFromDB()
        {
            return await Task.Run(() => animalDBContext.TableAnimals.ToList());
        }
    }
}
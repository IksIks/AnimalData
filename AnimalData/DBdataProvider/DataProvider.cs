using AnimalData.DBContext;
using AnimalData.Model.BaseClass;

namespace AnimalData.DBdataProvider
{
    internal class DataProvider
    {
        private AnimalDBContext dbContext = new();

        public DataProvider()
        {
        }

        public async Task<ICollection<TableAnimal>> GetDataFromDB()
        {
            return await Task.Run(() => dbContext.TableAnimals.ToList());
        }
    }
}
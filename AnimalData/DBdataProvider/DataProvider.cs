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

        public ICollection<TableAnimal> GetDataFromDB()
        {
            return dbContext.TableAnimals.ToList();
        }
    }
}
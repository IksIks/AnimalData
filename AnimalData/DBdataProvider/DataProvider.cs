using AnimalData.DBContext;
using AnimalData.Model.BaseClass;

namespace AnimalData.DBdataProvider
{
    internal class DataProvider
    {
        private AnimalDBContext? dbContext;

        public DataProvider()
        {
        }

        public async Task<ICollection<TableAnimal>> GetDataFromDB()
        {
            using (dbContext = new AnimalDBContext())
            {
                return await Task.Run(() => dbContext.TableAnimals.ToList());
            }
        }
    }
}
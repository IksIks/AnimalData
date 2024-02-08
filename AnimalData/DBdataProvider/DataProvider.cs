using AnimalData.DBContext;
using AnimalData.Model.BaseClass;

namespace AnimalData.DBdataProvider
{
    internal class DataProvider
    {
        private AnimalDBContext? dbContext;

        public DataProvider()
        {
            dbContext = new AnimalDBContext();
        }

        public async Task<ICollection<TableAnimal>> GetDataFromDB()
        {
            using (dbContext = new AnimalDBContext())
            {
                return await Task.Run(() => dbContext.TableAnimals.ToList());
            }
        }

        public void AddToDB(ChordalType animal)
        {
            using (dbContext = new AnimalDBContext())
            {
                dbContext.TableAnimals.Add(animal as TableAnimal);
                dbContext.SaveChanges();
            }
        }
    }
}
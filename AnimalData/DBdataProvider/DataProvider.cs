using AnimalData.DBContext;
using AnimalData.Model.BaseClass;
using System.Linq;

namespace AnimalData.DBdataProvider
{
    internal class DataProvider
    {
        private AnimalDBContext? dbContext;

        internal static event Action DataChange;

        public DataProvider()
        {
            dbContext = new AnimalDBContext();
        }

        public async Task<ICollection<TableAnimal>> GetDataFromDB()
        {
            using (dbContext = new AnimalDBContext())
            {
                return await Task.Run(() => dbContext.TableAnimals.OrderBy(a => a.Id).ToList());
            }
        }

        public void AddToDB(ChordalType animal)
        {
            using (dbContext = new AnimalDBContext())
            {
                dbContext.TableAnimals.Add(animal as TableAnimal);
                dbContext.SaveChanges();
                DataChange.Invoke();
            }
        }

        public void DeleteAnimalFromDB(ChordalType animal)
        {
            using (dbContext = new AnimalDBContext())
            {
                dbContext.TableAnimals.Remove(animal as TableAnimal);
                dbContext.SaveChanges();
                DataChange?.Invoke();
            }
        }

        public void UpdateAnimalData(ChordalType animal)
        {
            using (dbContext = new AnimalDBContext())
            {
                dbContext.TableAnimals.Update((animal as TableAnimal));
                dbContext.SaveChanges();
                DataChange?.Invoke();
            }
        }
    }
}
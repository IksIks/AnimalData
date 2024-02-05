using AnimalData.DBContext;
using AnimalData.Model;

namespace AnimalData.DBdataProvider
{
    internal class DataProvider
    {
        private AnimalDBContext dbContext;

        public DataProvider()
        {
        }

        public Task<ICollection<ChordalType>> GetDataFromDB(ChordalType chordalType)
        {
            using (dbContext = new AnimalDBContext())
            {
                var entity = dbContext.Entry<ChordalType>(chordalType);
                return dbContext.
            }
        }
    }
}
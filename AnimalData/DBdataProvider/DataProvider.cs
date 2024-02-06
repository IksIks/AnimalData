using AnimalData.DBContext;
using AnimalData.Model;
using Microsoft.EntityFrameworkCore;

namespace AnimalData.DBdataProvider
{
    internal class DataProvider
    {
        private AnimalDBContext dbContext;

        public DataProvider()
        {
        }

        //public Task<ICollection<ChordalType>> GetDataFromDB()
        //{
        //    dbContext.Mammals.ToList();
        //    dbContext.Amphibians.ToList();
        //    dbContext.Birds.ToList();
        //}
    }
}
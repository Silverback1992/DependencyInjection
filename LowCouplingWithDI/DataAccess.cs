using LowCouplingWithDI.Interfaces;

namespace LowCouplingWithDI
{
    public class DataAccess : IDataAccess
    {
        public void Store(string? userName, string? password)
        {
            //writing data to the db
        }
    }
}
using LowCouplingWithDI.Interfaces;

namespace LowCouplingWithDI
{
    public class Business : IBusiness
    {
        private IDataAccess _dataAccess;

        public Business(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SignUp(string? userName, string? password)
        {
            //validation code...

            _dataAccess.Store(userName, password);
        }
    }
}
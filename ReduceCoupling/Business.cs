using ReduceCoupling.Interfaces;

namespace ReducedCoupling
{
    public class Business : IBusiness
    {
        public void SignUp(string? userName, string? password)
        {
            //validation code...

            var dataAccess = new DataAccess();
            dataAccess.Store(userName, password);
        }
    }
}
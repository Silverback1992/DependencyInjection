namespace HighlyCoupled
{
    public class Business
    {
        public void SignUp(string? userName, string? password)
        {
            //validation code...

            var dataAccess = new DataAccess();
            dataAccess.Store(userName, password);
        }
    }
}
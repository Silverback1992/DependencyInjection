namespace LowCouplingWithDI.Interfaces
{
    public interface IDataAccess
    {
        void Store(string? userName, string? password);
    }
}
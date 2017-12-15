namespace Interfaces
{
    public interface IDatabase
    {
        bool IsConnected { get; }
        void Connect();
        User GetUser(string firstName, string lastName);
        void SaveChanges();
    }
}

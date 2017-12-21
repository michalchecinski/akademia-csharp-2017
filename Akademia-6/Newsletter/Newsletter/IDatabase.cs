using System.Collections.Generic;

namespace Newsletter
{
    public interface IDatabase
    {
        bool IsConnected { get; }
        void Connect();
        User GetUser(string firstName, string lastName);
        void AddUser(string firstName, string lastName, string email);

        IList<User> GetAllUsers();

        void SaveChanges();
    }
}

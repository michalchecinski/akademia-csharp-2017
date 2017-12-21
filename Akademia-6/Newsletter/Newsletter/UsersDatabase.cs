using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter
{
    public class UsersDatabase : IDatabase
    {
        private static List<User> users = new List<User>();

        public bool IsConnected => true;

        public void Connect()
        {
            Console.WriteLine("Connecting...");
        }

        public void AddUser(string firstName, string lastName, string email)
        {
            users.Add(new User(firstName, lastName, email));
        }

        public User GetUser(string firstName, string lastName)
        {
            foreach (User user in users)
            {
                if(user.FirstName.Equals(firstName) && user.LastName.Equals(lastName))
                {
                    return user;
                }
            }

            return null;

        }

        public void SaveChanges()
        {
            Console.WriteLine("Changes saved.");
        }

        public IList<User> GetAllUsers()
        {
            return users;
        }
    }
}
;
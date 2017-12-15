using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class UsersDatabase : IDatabase
    {
        public bool IsConnected => true;

        public void Connect()
        {
            Console.WriteLine("Connecting...");
        }

        public User GetUser(string firstName, string lastName)
        {
            User user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.PhoneNumber = "123456789";
            user.Email = firstName + lastName + "@mail.com";
            return user;
        }

        public void SaveChanges()
        {
            Console.WriteLine("Changes saved.");
        }
    }
}
;
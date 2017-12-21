using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter
{
    public class NewsletterProcessor
    {
        private readonly ISeder _sender;
        private readonly IDatabase _database;

        public NewsletterProcessor(ISeder seder, IDatabase database)
        {
            _sender = seder;
            _database = database;
        }

        public void SendMessage()
        {
            _database.Connect();
            User user = _database.GetUser("Jan", "Kowalski");
            _sender.SendMessage(user.Email, "Newsletter od EE", "Wiadomości od dziekana:....");
        }
    }
}

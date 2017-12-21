using System;

namespace Newsletter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new UsersDatabase();
            //Użytkownik z mailem na który chcesz dostać wiadomość
            database.AddUser("Imie", "Nazwisko", "mail@mail.com");

            ISeder sender = new FormalEmailSender();

            //Wysyłanie maili do wszystkich użytkowników w bazie:
            foreach (User user in database.GetAllUsers())
            {
                sender.SendMessage(user.Email, "temat", "treść");
            }

            //Użytkownik którego chcemy pobrać
            User me = database.GetUser("Imie", "Nazwisko");

            if(me != null)
            {
                sender.SendMessage(me.Email, "temat", "treść");
            }
            else
            {
                Console.WriteLine("nie ma takiego uzytkownika");
            }

            

            
            
        }
    }
}

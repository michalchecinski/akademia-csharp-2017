using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Newsletter
{
    class FormalEmailSender : ISeder
    {
        public void SendMessage(string email, string title, string message)
        {
            MailMessage mail = new MailMessage();

            //Z jakiego adresu ma zostać wysłany email. 
            //Najczęściej jest to ten sam email pod który konfigutujemy serwer
            mail.From = new MailAddress("mail@mail.com");

            //Dodawanie maili odbiorców:
            mail.To.Add(email);

            //Tytuł maila
            mail.Subject = title;

            //Treść maila:
            mail.Body = $"Szanowny Panie: { message}";

            //Serwer SMTP poczty z której będziemy wysyłać maile:
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            SmtpServer.Port = 587;

            //Login i hasło do skrzynki z której bedzie wysłany mail
            //Odkomentuj poniższą linję i wpisz swoje dane:
            //SmtpServer.Credentials = new NetworkCredential("mail@mail.com", "password");
            SmtpServer.EnableSsl = true;

            //Wysłanie maila:
            SmtpServer.Send(mail);
        }
    }
}

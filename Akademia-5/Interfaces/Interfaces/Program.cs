using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsletterProcessor formalNewsletter = new NewsletterProcessor(new FormalEmailSender(), new UsersDatabase());
            formalNewsletter.SendMessage();

            NewsletterProcessor newsletter = new NewsletterProcessor(new EmailSender(), new UsersDatabase());
            newsletter.SendMessage();
        }
    }
}

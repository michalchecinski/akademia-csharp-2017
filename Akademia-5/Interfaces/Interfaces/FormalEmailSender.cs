using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class FormalEmailSender : ISeder
    {
        public void SendMessage(string contact, string title, string message)
        {
            Console.WriteLine($"Do: Sz.P. {contact} Treść: Szanowny Panie: {message}");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter
{
    public class EmailSender : ISeder
    {
        public void SendMessage(string contact, string title, string message)
        {
            Console.WriteLine($"Do: {contact}, Tytuł: {title} Wiadomość: {message}");
        }
    }
}

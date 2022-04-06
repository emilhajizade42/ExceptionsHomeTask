using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modals
{
    internal class EmailSender:MessageSender
    {
        public override void  SendMessage()
        {
            Console.WriteLine("Email sender is working");
        }
    }
}

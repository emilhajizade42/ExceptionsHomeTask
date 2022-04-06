using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modals
{
    internal class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Sms message   is working");
        }
    }
}

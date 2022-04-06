using ConsoleApp1.Modals;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var email = new EmailSender();
            var sms = new SmsSender();
            bool programRun = true;

            while (programRun)
            {
                Logic();
            }

            static void ShowMenu()
            {
                Console.WriteLine("-----");
                Console.WriteLine("1) email send");
                Console.WriteLine("2) sms send");
                Console.WriteLine("0) exit program");
                Console.WriteLine("-----");
            }
            static string GetKeydown()
            {
                var a = Console.ReadLine();
                if (a=="1" ||a=="2" || a=="0")
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("wrong value auto exit ");
                    return "0";
                }
            }

            void Logic()
            {
                ShowMenu();
                switch (GetKeydown())
                {
                    case "1":
                        email.SendMessage();
                        break;
                    case "2":
                        sms.SendMessage();
                        break;
                    case "0":
                        programRun = false;
                        break;
                    
                }
              
            }
        }
    }
}

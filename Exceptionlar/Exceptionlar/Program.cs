using System;

namespace Exceptionlar.Utilites.MyExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            try
            {
                int n = int.Parse("salam");
            }
            catch (Exception)
            {

                throw new Myexception1("Oz yazdigimiz exception");
            }

                
            
            

                
            

           
        }
    }
}

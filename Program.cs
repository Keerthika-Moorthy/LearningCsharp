using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            SingletonClass sc = new SingletonClass();
           sc.Message("Request Message from Manager");

            SingletonClass scobj  = new SingletonClass();
            scobj.Message("Request Message from Employee");

            Console.ReadLine();
           
        }
    }
}

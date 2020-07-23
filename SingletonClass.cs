using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonClass
    {
        static int instanceCounter = 0;
        public SingletonClass()
        {
            instanceCounter++;
            Console.WriteLine("Instances created " + instanceCounter);
        } 
        public void Message(string message)
        {
           Console.WriteLine("Message " + message);
        }
    }
}

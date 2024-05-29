using System;
using System.Data.Common;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString("Shakil");
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char c in messageArray) 
            {
                Console.WriteLine(c);   
            }
        }

    }
}

using System;
using System.Data;
using System.Data.Common;
using System.Security.AccessControl;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            Console.ReadLine();

        }


    }
}

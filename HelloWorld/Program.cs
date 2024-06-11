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
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "M3";
            myCar.Year = 2024;
            myCar.Colour = "Black";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);
            Console.ReadLine();
        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public String Colour { get; set; }

        }

    }
}

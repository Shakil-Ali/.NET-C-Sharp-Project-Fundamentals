using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Security.AccessControl;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {Make = "BMW", Model = "M3", Colour = "Black"},
                new Car() {Make = "Lamborghini", Model = "Urus", Colour = "Yellow"}
            };

            // LINQ Query
            var bmws = from car in myCars
                       where car.Model == "BMW"
                       select car;

            // LINQ Method
            foreach (var car in bmws) 
            {
                Console.WriteLine("{0} {1}", car.Model, car.Colour);
            }

            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }

    }

    
}

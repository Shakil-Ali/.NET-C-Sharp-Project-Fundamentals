using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Shakil's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();

        }
    }
}

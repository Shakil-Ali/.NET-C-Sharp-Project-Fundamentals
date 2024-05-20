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
            string message = "";


            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2") 
            {
                message = "You won a new boat!";
            }
            else if(userValue == "3") 
            {
                message = "You won a new plane!";
            }
            else 
            {
                message = "Sorry we didn't understand";
                message += message + ". You Lose";
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}

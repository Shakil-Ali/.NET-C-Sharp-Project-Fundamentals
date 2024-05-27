using System;
using System.Data.Common;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers.Length);
            //Console.ReadLine();

            //int[] numbers2 = new int[] { 1, 2, 3, 4 };

            //string[] names = new string[] { "Shakil", "Ali" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();

            string zig = "You can get what you want out of life" +
                " If you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char c in charArray )
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }
    }
}

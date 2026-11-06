using System;

namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine($"your name is {name}");
            }
            else
            {
                Console.WriteLine("The string is empty.");
            }
        }
    }
}

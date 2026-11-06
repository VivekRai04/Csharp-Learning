using System;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vivek";
            int age = 22;

            Console.WriteLine("your name is {0} and your age is {1}", name, age); //composite formatting 
        }
    }
}

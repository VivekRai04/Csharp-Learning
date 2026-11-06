using System;

namespace isNullorEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            //string name = null;
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("0");
            }
            if (!name.Equals(""))   // if null then cannot perform operations on null
            {
                Console.WriteLine("1");
            }
            if (!string.IsNullOrEmpty(name)) // if no input then empty
            {
                Console.WriteLine("2");
            }
        }
    }
}

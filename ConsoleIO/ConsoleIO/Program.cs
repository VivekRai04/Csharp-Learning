using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);
            Console.WriteLine("Your name is "+ name + " and your age is " + age );
        }
    }
}

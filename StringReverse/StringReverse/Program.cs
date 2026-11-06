using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name:");
            string name  = Console.ReadLine();
            Console.WriteLine(name.Length);

            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

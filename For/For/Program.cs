using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to repeat:");
            string msg = Console.ReadLine();
            Console.Write("How many times do you want the loop to run?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter < 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                for (int i = 1; i <= loopCounter; i++)
                {
                    Console.WriteLine(msg);
                }
            }
        }
    }
}

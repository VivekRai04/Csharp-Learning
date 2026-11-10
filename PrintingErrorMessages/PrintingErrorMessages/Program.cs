using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingErrorMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine()); // cannot access num outside the try block
            }

            //catch (OverflowException)
            //{
            //    Console.WriteLine("Enter number less then 2 billion");
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("Please only enter numbers");
            //}

            catch (Exception e) // catch all
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}

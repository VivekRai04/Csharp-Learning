using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6,7,8
            };

            Console.WriteLine("Enter a number to search");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, search);
            //int position = Array.IndexOf(numbers, search , 2); // start searching from position 2
            //int position = Array.IndexOf(numbers, search, 2,5); // start searching from position 2 and end at position 5

            if (position > -1)
            {
                Console.WriteLine($"number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"the number {search} has not been found");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1,2,5,7,8,4,6,7,6
            };

            Array.Sort(numbers); // returns void therefore no need to save

            foreach (int nums in numbers)
            {
                Console.WriteLine(nums);
            }
        }
    }
}

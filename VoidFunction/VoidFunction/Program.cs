using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateandPrintArray(); // function has no return type therefore can be called directly.
            //if a function is not a void(it returns a datatype) then can be stored in a variable.
        }

        static void CreateandPrintArray()
        {
            int [] numbers = new int[] { 1, 2, 3, 4 };

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}

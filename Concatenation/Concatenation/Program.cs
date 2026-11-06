
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vivek";
            int age = 22;
            string test = string.Concat("your name is ", name, " and your age is ", age);
            Console.WriteLine(test);
        }
    }
}

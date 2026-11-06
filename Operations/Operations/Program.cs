using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            age++;
            age = age + 1; // all three do the same thing. 
            age += 1;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);


            double age1 = 23;
            age1 /= 10;
            Console.WriteLine(age1); // integer ans is 2.3 but .3 gets trucated.

            string name = "Vivek ";
            name += "is programming";
            Console.WriteLine(name);

            int i = 0, j=0;
            Console.WriteLine(i++); // first prints i then increments. 
            Console.WriteLine(++j); // first increments then prints
        }
    }
}

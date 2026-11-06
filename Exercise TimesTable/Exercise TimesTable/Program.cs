using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number , i , number * i );
            }
        }
    }
}

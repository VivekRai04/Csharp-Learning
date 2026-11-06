using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age1; //initialization
            age1 = 10; // Declaration
            int age = -23; // initializing and declaring
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long BigNumber = 90000000000;
            Console.WriteLine(BigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MaxValue);

            double negetive = 55.2;
            Console.WriteLine(negetive);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.0000F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MaxValue);
        }
    }
}

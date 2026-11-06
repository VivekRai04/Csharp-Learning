using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vivek";
            int num = 01213223423;
            string num1 = "01213223423";
            int age = 23;

            Console.WriteLine( name );
            Console.WriteLine( num );  // starting 0 does not get printed.
            Console.WriteLine( num1 ); // 0 gets printed bcuz its datatype is string. else use var
            Console.WriteLine( age );


            Console.WriteLine("Exercise");
            int a = 10;
            int b = 2;
            Console.WriteLine( a % b );

            a = 21;
            Console.WriteLine(a % b);
        }
    }
}

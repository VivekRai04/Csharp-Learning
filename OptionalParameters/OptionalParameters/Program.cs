using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static int add(int a, int b = 50)  // b is set to 50
            {
            return a + b;  
            }
        
        static int add1(int a, int b = default) // default keyoword  b is 0
            {
            return a + b;  
            }

        static int add2(int a, [Optional] int b) // using optional Keyword, uses import  b is zero
            {
            return a + b;  
            }



        static void Main(string[] args)
        {
            int result = add(5); // will override 0 from the fucntion if given second paramenter 
            Console.WriteLine(result);
        }
    }
}

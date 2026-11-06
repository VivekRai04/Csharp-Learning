using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        public static void something()
        {
            Console.WriteLine("From static fucntion.");
        }
    }

    class Test1
    {
        public void something1()
        {
            Console.WriteLine("From non static fucntion.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMsg(); //called directly because welcome function is static and it can be used anaywhere.
            Test.something(); //without creating an instance of the class.
            Test1 test = new Test1(); //creating an instance.
            test.something1();
            
        }

        static void WelcomeMsg()
        {
            Console.WriteLine("Welcome Vivek");
        }
    }
}

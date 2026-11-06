using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {
        //static string name = "Vivek";
        static void Main(string[] args)
        {
            Console.Title = returnName(); // or use string name
            PrintIntro();
        }

        static string returnName()
        {
            return "Vivek";
        }

        static int returnAge()
        {
            return 21;
        }

        static void PrintIntro()
        {
            Console.WriteLine($"{returnName()} - {returnAge()}");  // or use string name
        }
    }
}
    



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {
        static string name = "Vivek";
        static void Main(string[] args)
        {
            Console.Title = "Vivek";
            PrintIntro();
        }


        static void PrintIntro()
        {
            Console.WriteLine("Vivek");
        }
    }
}
    



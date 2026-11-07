using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Assign(ref int num , ref string name)
        {
            name = "VivekFunc";
            num = 20;
        }
        static void Main(string[] args)
        {
            int num = 10;
            string name = "Vivek";
            Assign(ref num, ref name);  // passed by reference
            Console.WriteLine(num);
            Console.WriteLine(name);
        }
    }
}

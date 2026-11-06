using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7; 
            int length = 5;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = num * (i+1) ;
            }

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVat = vat / 100;
            int balance = 1000;

            Console.WriteLine(balance *(vat/100D));
            Console.WriteLine(balance *percentVat );
            Console.WriteLine(vat);

        }
    }
}

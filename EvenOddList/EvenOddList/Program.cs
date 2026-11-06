using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else 
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine("The even list is:");
            foreach ( int evenList in even)
            {
                Console.Write($"{evenList}");
            }

            Console.Write("The odd list is");
            foreach ( int oddList in odd)
            {
                Console.Write(oddList);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>()
            {
                1,2,3,4,5,6
            };

            List<int> Numberss = new List<int>();
            Numberss.Add(1);
            Numberss.Add(2);
            Numberss.Add(3);

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (int num in listNumbers)
            {
                Console.WriteLine(num);
            }

            //listNumbers. //Check tootip for all the fucntions related to list

        }
    }
}

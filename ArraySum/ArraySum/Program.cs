using System;

namespace ArraySum
{
    internal class Program
    {
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return -1;
            }
            int result = 0;
            foreach (int number in numbers)
            {
                result = result + number;
            }
            return result;
        }
        static void Main(string[] args)
        {

            int size = 0;
            Console.WriteLine("Enter the count of numbers:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No data will be entered in the array");
            }

            else
            {
                size = Convert.ToInt32(input);
                if (size < 0) 
                {
                    Console.WriteLine("Array size cannot be negative.");
                    return; //return simply terminates the method.
                }
            }

            int[] num = new int[size];

            if (size > 0)
            {
                for (int i = 0; i < size; i++)
                {

                    Console.WriteLine("Enter a number: ");
                    int inputNum = Convert.ToInt32(Console.ReadLine());

                    num[i] = inputNum;
                }
            }

            else
            {
                Console.WriteLine("No data will be entered in the array");
            }

            int result = SumOfNumbers(num);
            if (result < 0)
            {
                Console.WriteLine("No data in the array");
            }
            else
            {
                Console.WriteLine($"The sum of the numbers is {result}");
            }
        }
    }
}

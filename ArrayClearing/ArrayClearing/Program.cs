using System;

namespace ArrayClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
           {
                1,2,5,7,8,4,6,7,6
           };

            Array.Clear(numbers, 0, numbers.Length);

            foreach (int nums in numbers)
            {
                Console.WriteLine(nums);
            }
        }
    }
}

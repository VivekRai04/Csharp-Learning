using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 5;
            number[1] = 10;
            number[2] = 15;

            int[] nums = { 1, 2, 3, 4, 5 };

            Console.WriteLine($"{number[0]},{number[1]},{number[2]}");
            Console.WriteLine($"{nums[0]},{nums[1]},{nums[2]}");

            for (int i = 0; i<nums.Length;i++) 
            {
                Console.WriteLine(nums[i]); 
            }

            foreach (int num in nums)
            {
                Console.Write(num);
            }
        }
    }
}


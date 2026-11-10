using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool success = false;
            //while (!success)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter a number");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        success = true;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Error: {e.Message}");
            //    }
            //Console.WriteLine(success ? "yay" : "Oh no");
            //}

            Console.WriteLine("Enter a number:");
            if (TryParse(Console.ReadLine(), out int result))
             {
                Console.WriteLine("yay" + result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }

        }
       static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

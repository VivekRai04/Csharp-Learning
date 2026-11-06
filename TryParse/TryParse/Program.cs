using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string numInput = Console.ReadLine();
            //int num = Convert.ToInt32(numInput); // input:10h gives an error 

            bool success = int.TryParse(numInput, out int numOutput); // if input zero then it looks like the number didnt parse without the if else.

            if (success)
            {
                Console.WriteLine(numOutput);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }



        }
    }
}

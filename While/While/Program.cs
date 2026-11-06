using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            string num1Input = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Input);

            Console.Write("Enter the second number:");
            string num2Input = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Input);

            int answer = num1 * num2;
            int actualAns = 0;

            Console.Write("Value of " + num1 + " x " + num2 + ":");

            //while (actualAns != answer)
            //{
            //    string ansInput = Console.ReadLine();
            //    actualAns = Convert.ToInt32(ansInput);

            //    if (actualAns == answer)
            //    {
            //        Console.WriteLine("You are smart!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are dumb! Try again");
            //        Console.Write("Value of " + num1 + " x " + num2 + ":");
            //    }
            //}

            do
            {
                string ansInput = Console.ReadLine();
                actualAns = Convert.ToInt32(ansInput);

                if (actualAns == answer)
                {
                    Console.WriteLine("You are smart!");
                }
                else
                {
                    Console.WriteLine("You are dumb! Try again");
                    Console.Write("Value of " + num1 + " x " + num2 + ":");
                }
            }
            while (actualAns != answer);
        }
    }
}

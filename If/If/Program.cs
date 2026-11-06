using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Enter your name:");
            //    string name = Console.ReadLine();
            //    Console.Write("Enter your age:");
            //    string inputAge = Console.ReadLine();
            //    int age = Convert.ToInt32(inputAge); // bcuz cannot do less than or more than to strings in conditions to strings. 
            //    Console.WriteLine("Your name is " + name + " and your age is " + age);


            //    if (age <= 0 || age >= 150)
            //    {
            //        Console.WriteLine("Invalid age");
            //    }
            //    else
            //    {
            //        if (age >= 18 && age < 60)
            //        {
            //            Console.WriteLine("Your are an adult");
            //        }
            //        else if (age >= 60)
            //        {
            //            Console.WriteLine("You are a boomer");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your are a teenager");
            //        }

            Console.Write("Enter the first number:");
            string num1Input = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Input);

            Console.Write("Enter the second number:");
            string num2Input = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Input);

            int answer = num1 * num2;

            Console.Write("Value of " + num1 + " x " + num2 + ":");
            string ansInput = Console.ReadLine();
            int actualAns =  Convert.ToInt32(ansInput);

            if(actualAns == answer)
            {
                Console.WriteLine("You are smart!");
            }
            else
            {
                Console.WriteLine("You are dumb");
            }
        }
        }
    }

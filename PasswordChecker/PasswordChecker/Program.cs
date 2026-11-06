using System;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a new password:");
            string pass1 = Console.ReadLine();

            Console.Write("Enter the new password again:");
            string pass2 = Console.ReadLine();

            if (!pass1.Equals(string.Empty))
            {
                if (!pass2.Equals(string.Empty))
                {
                    if (pass1.Length >= 6 && pass2.Length >= 6)
                    {
                        if (pass1.Equals(pass2))
                        {
                            Console.WriteLine("Passwords Match");
                        }

                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The password should be 6 or more characters");
                    }

                }
                else
                {
                    Console.WriteLine("Enter confirmation password");
                }

            }
            else
            {
                Console.WriteLine("Please enter the password");
            }
        }
    }
}

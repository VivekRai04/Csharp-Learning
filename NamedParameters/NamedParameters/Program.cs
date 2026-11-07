using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"address: {address}");
        }
        static void Main(string[] args)
        {
            string nameInput = "Vivek Rai";
            int ageInput = 22;
            string addressInput = "India";

            PrintDetails(address:addressInput , name:nameInput , age:ageInput);  //named parameters : custom argument order
        }
    }
}

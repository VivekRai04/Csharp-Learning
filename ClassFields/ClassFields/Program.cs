using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age) // constructor
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name)  //Setters  an example of encapsulation
            {
                this.name = name;
            }

            public string GetName( )  //Getters  
            {
                return name;
            }

            public int GetAge() => age;  // setter

            public string ReturnDetails()
            {
                return $"Name: {name} - age: {age}"; //directly accessing the variables because they are local.
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Vivek", 22);
            // Console.WriteLine($"{person.name} - {person.age}");  // will give error because variables are made private
            //person.name = "Maverick"; // will give error because variables are made private
            //person.age = 22; // will give error because variables are made private


            Console.WriteLine(person.ReturnDetails()); //method function
            person.SetName("Maverick");
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is: {person.GetName()}"); // using getters


        }
    }
}
    

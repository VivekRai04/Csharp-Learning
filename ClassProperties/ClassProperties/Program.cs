using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;
            public string Name
            {
                get 
                { 
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            //public int Age 
            //{
            //    get 
            //    {
            //        return age;
            //    }

            //    set 
            //    {
            //        age = value;
            //    }
            //}

            public int Age { get => age; set => age = value; } // both above and this do the same thing

            public Person(string name, int age)
            {
                Name = name; 
                Age = age;
            }
            
        }
        static void Main(string[] args)
        {
            Person person = new Person("Vivek", 22);
            person.Name = "Maverick";
            person.Age = 26;
            Console.WriteLine($"Class property: {person.Name}");
            Console.WriteLine($"Class property: {person.Age}");
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ClassFunctions
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age) // constructor
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name} - age: {age}"; //directly accessing the variables because they are local.
            }
        }


            static string ReturnDetails(Person person)
            {
                return $"Name: {person.name} - age: {person.age}";
            }


            static void Main(string[] args)
            {
                Person person = new Person("Vivek", 22);
                Console.WriteLine($"{person.name} - {person.age}");
                Console.WriteLine(ReturnDetails(person));
                Console.WriteLine(person.ReturnDetails()); //method function

            }
        }
    }

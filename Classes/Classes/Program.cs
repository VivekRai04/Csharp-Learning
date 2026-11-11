using System;

namespace Classes
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

            //cannot do the below in structures, have to add all the parameters in constructor when using structures.
            // parameter overloading
            public Person(string name) // constructor
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age) // constructor
            {
                this.name = "";
                this.age = age;
            }
            public Person() // constructor
            {

            }
            static void Main(string[] args)
            {
                Person person = new Person("Vivek", 22);
                Console.WriteLine($"{person.name} - {person.age}");
                //Person person = new Person(22);
                //Person person = new Person("Vivek");
                //Person person = new Person();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct Person
        {
            public string name; //! Name
            public int num;

            public Person(string name, int num)  // constructor
            {
                this.name = name; //! then Name = name will reference to string name in the struct. but if same name then use "this"
                this.num = num;
            }
        }
        static void Main(string[] args)
        {
            Person person;
            person.name = "Vivek";
            // person.num = 10;  not accesible bcuz default is private.
            person.num = 10;
            Console.WriteLine($"{person.name} - {person.num}");



            Person Newperson = ReturnPerson();
            Console.WriteLine($"{Newperson.name} - {Newperson.num}");

        }

        static Person ReturnPerson()
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            //Person person;

            //person.name = name;
            //person.num = num;

            //return person;

            return new Person(name, num);
        }
    }
}

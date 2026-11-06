using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instead of Dictionary<int, string> also var can be used
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "Vivek" },
                {20, "Vivek" },
                {3, "Vivek" }
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key}-{pair.Value}");
            }

            foreach (KeyValuePair<int, string> num in names)
            {
                Console.WriteLine($"{num.Key}-{num.Value}");
            }


            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Science", "Vivek"},
                {"Commerce", "Ayush"}
            };

            Console.WriteLine(teachers["Science"]);  // crashes if the key is wrongs.

            if (teachers.TryGetValue("Scienc", out string name)) // does not crash
            {
                Console.WriteLine(name);
            }
            else {
                Console.WriteLine("Teacher not found");
            }

            teachers["Commerce"] = "Shreya";  // update data

            foreach (KeyValuePair<string, string> named in teachers)
            {
                Console.WriteLine($"{named.Key}-{named.Value}");
            }

        }
    }
}

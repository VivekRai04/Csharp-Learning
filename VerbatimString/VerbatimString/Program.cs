using System;

namespace VerbatimString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            string path = @"C:\users\admin\Vivek";
            Console.WriteLine(path);
            path = "C:\\users\\admin\\Vivek\nNew Line Test";
            Console.WriteLine(speech);
            Console.WriteLine(path);
            path = @"C:\\users\\admin\\Vivek\nNew Line Test"; // verbatim Identifier
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);
        }
    }
}

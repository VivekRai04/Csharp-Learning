using System;

class Program
{
    static void Main()
    {
        // 1. Setup the variables exactly like your screenshot
        string message = "Hello";
        char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };

        // This creates a brand new string instance in memory, boxed inside an object variable
        object newCompare = new string(chars);

        Console.WriteLine($"Comparing string \"{message}\" with object holding \"{newCompare}\":\n");

        // 2. CASE 1: Using .Equals() -> Looks at LITERAL DATA
        // Because .Equals() evaluates the actual instance type at runtime, 
        // it unboxes the string and checks the characters.
        if (message.Equals(newCompare))
        {
            Console.WriteLine(".Equals() Output: Same");
        }
        else
        {
            Console.WriteLine(".Equals() Output: Different");
        }

        // 3. CASE 2: Using == -> Looks at MEMORY REFERENCE and the datatype
        // Because 'newCompare' is declared as an 'object', C# drops the string-specific 
        // rule for == and checks if they share the exact same spot in memory.
        if (message == newCompare)
        {
            Console.WriteLine("== Operator Output: Same");
        }
        else
        {
            Console.WriteLine("== Operator Output: Different");
        }
    }
}

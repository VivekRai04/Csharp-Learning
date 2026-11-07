using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalAreaOfTriangle
{
    internal class Program
    {

        static int Calarea(int width , int height)
        {
            return (width * height) / 2;
        }

        static void TakeInput(out int inputWidth , out int inputHeight)
        {
            Console.WriteLine("Enter Base widhth of the triangle");
            inputWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of the triangle");
            inputHeight = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int width;
            int height;
            TakeInput( out width , out height);

            int result = Calarea(width, height);
            Console.WriteLine($"The area of the triangle is {result}");
        }
    }
}

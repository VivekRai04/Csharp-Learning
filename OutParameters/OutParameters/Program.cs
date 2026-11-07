using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        static int CalculateResult(int maths, int science, out double percentage)
        {
            int total = maths + science;

            percentage = ((double)total/200) * 100;

            return total;
        }
        static void Main(string[] args)
        {
            int maths = 90;
            int science = 80;
            double studentPercentage;
            int totalMarks = CalculateResult(maths, science , out studentPercentage);

            Console.WriteLine(totalMarks);
            Console.WriteLine(studentPercentage);
        }
    }
}

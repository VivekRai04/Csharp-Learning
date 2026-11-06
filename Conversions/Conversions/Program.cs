using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-9000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegetive = "-55.2";
            double negetive = Convert.ToDouble(textNegetive);
            Console.WriteLine(negetive);

            string textprecision = "5.00001";
            float precision = Convert.ToSingle(textprecision);
            Console.WriteLine(precision);

            string textmoney = "14.99M";
            decimal money = Convert.ToDecimal(textmoney);
            Console.WriteLine(money);
        }
    }
}

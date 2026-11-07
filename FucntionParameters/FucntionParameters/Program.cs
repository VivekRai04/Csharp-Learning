using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FucntionParameters
{
    internal class Program
    {
        static int TotalSubject = 300;
        static void DisplayStudent(string name, int age, string course)
        {
            Console.WriteLine("\n Student Details");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
        }

        static int CalculateTotal(int maths, int science, int english)
        {
            return( maths + science + english );
        }

        static double CalculatePercentage(int total, int totalSubjects)
        {
            return ((double)total / totalSubjects) * 100;
        }

        static void CheckResult(double percentage)
        {
            if (percentage >= 40)
            {
                Console.WriteLine("Result:Pass");
            }
            else
            {
                Console.WriteLine("Result:Fail");
            }
        }

        static void DisplayGrade(double percentage)
        {
            if (percentage >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
        static void Main(string[] args)
        {
            string studentName = "Vivek";
            int studentAge = 21;
            string course = "IT";

            int maths = 85;
            int science = 90;
            int english = 80;

            DisplayStudent(studentName, studentAge, course);

            int totalMarks = CalculateTotal(maths, science, english);

            Console.WriteLine("\nTotal Marks:" + totalMarks);
            
            double percentage = CalculatePercentage(totalMarks, TotalSubject);

            Console.WriteLine("Percentage: " + percentage + "%");

            CheckResult(percentage);

            DisplayGrade(percentage);
        }
    }
}

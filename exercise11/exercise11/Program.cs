using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program allows a teacher to enter an amount of students. For each student program asks the teacher to enter their name and final score for the class.
            // When all students have been entered, program will print the highest grade in class and the class average.


            Console.WriteLine("Enter amount of students in class");
            int amountofStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[amountofStudents];
            double[] grades = new double[amountofStudents];

            for (int i = 0; i < amountofStudents; i++)
            {
                Console.WriteLine("Enter student #{0} name", i + 1);
                string Name = Console.ReadLine();
                studentNames[i] = Name;
                Console.WriteLine("Enter student #{0} grade", i + 1);
                double Grade = double.Parse(Console.ReadLine());
                grades[i] = Grade;
                averageGrade += Grade;
                if (Grade > highestGrade)
                {
                    highestGrade = Grade;
                    highestGradeName = Name;
                }
            }
            //Printing
            averageGrade /= amountofStudents;
            Console.WriteLine("The average of the class is {0}", averageGrade);
            Console.WriteLine("The highest grade of the class is {0} and student name was {1}", highestGrade, highestGradeName);
        }
    }
}
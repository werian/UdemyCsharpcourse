using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        // program asks user for a interger. It passes the interger to methods to get square and cube of the said interger.
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number");
            int number = int.Parse(Console.ReadLine());

            int squared = Square(number);
            Console.WriteLine("Your number {0} squared = {1} ",number, squared);
           
            int cubed = Cube(number);            
            Console.WriteLine("Your number {0} cubed = {1}",number, cubed);

        }

        public static int Square(int number)
        {
            int answer = number *number;
            return answer;
        }
        public static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }
    }
}
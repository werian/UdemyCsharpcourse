using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program that asks user for total amount of time in minutes
            // Program then returns the amount of time in hours and minutes

            Console.WriteLine("Give amount of time in minutes");
            int TotalTimeinMinutes = int.Parse(Console.ReadLine());


            int Hours = TotalTimeinMinutes / 60;

            int RemainingMinutes = TotalTimeinMinutes % 60;

            Console.WriteLine("The amount of time in minutes was {0} which is equal to {1} hours and {2} minutes ", TotalTimeinMinutes, Hours, RemainingMinutes);
        }
    }
}
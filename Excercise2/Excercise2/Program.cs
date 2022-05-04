using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main (string[] args)
        {
            // Program that calculates area for a room from user input. Used for calculating price for carpeting with constant price of carpet per square meter.

            int CostofCarpet = 5;
            Console.WriteLine("Give length of the room");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Give width of the room");
            int Width = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculating costs");

            int area = Length * Width;

            int Price = area * CostofCarpet;

            Console.WriteLine("Your room was size of {0} square meters. Cost of the carpet is {1} Euros. The total cost of carpeting the room comes to {2} Euros ", area, CostofCarpet, Price);
        }
    }
}
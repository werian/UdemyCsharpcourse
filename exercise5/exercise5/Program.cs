using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program calculates fees for the lawn-moving company. 1 season of lawn-moving lasts 20 weeks. Fees will be determined by the size of the yard.


            Console.WriteLine("Give width of your yard:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Give length of your yard:");
            double length = double.Parse(Console.ReadLine());

            double squaremeter = width * length;
            double weeklyprice;

            if (squaremeter < 400)
            {
                weeklyprice = 25;
            }
            else if (squaremeter >= 400 && squaremeter > 600)
            {
                weeklyprice = 35;
            }
            else 
            {
                weeklyprice = 50;
            }

            Console.WriteLine("The weekly fee for your yard is {0} euros", weeklyprice);
            Console.WriteLine("the cost of 20 week season is {0} euros", weeklyprice * 20);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program takes hourly pay rate from a user. It will prompt error if the pay rate is lower than 7.50€ or higher than 49.00€. Otherwise program indicates that the rate is okay

            Console.WriteLine("Give pay rate:");
            double payrate = double.Parse(Console.ReadLine());

            if (payrate < 7.50 || payrate > 49.00)
            {
                Console.WriteLine("Invalid rate");
            }
            else
            {
                Console.WriteLine("Payrate is valid");
            }


        }

    }
}
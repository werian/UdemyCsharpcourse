using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program takes hourly rate from user and if the rate is lower than 5.65€ or higher than 49.99€, the program continues to prompt the user. 

            double payrate;
            do
            {
                Console.WriteLine("enter valid pay rate");
                payrate = double.Parse(Console.ReadLine());
            } while(payrate < 5.65 || payrate >49.99);

            Console.WriteLine("The valid payrate you entered is {0}", payrate);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for package delivery service. It holds zip codes in array. Program asks user for zip code and shows if the company delivers to the zip code.

            string[] zipCodes = { "10000", "60320", "60150", "60100", "60500", "60120", "60180", "60350", "60300", "60001" };
            Console.WriteLine("Enter zip code");
            string code = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (code == zipCodes[i])
                {
                    found = true;
                    break;
                }
            }
            
            if (found == true)
            {
                Console.WriteLine("We do ship to the zip code");
            }
            else
            {
                Console.WriteLine("We do not deliver to this zip code");
            }
        }

    }
}

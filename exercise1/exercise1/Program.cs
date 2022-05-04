using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise1
{
    class Program
    {
        // simple calculator, user input integers and adding them together
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first integer");
            int Firstinput = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second integer");
            int Secondinput = int.Parse(Console.ReadLine());

            int answer = Firstinput + Secondinput;

            Console.WriteLine("calculating following");
            Console.WriteLine("{0} + {1} = {2}", Firstinput, Secondinput, answer);

        }
    }

}
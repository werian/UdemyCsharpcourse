
using exercise16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        //Program uses class name square to contain fields for are and and length of the side.
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];

            for (int i = 1; i < 10; i++)
            {
                squares[i] = new Square(i+1);
                Console.WriteLine("{0,2}, {1,2}",squares[i].Side, squares[i].Area);
            
            }


        }
    }
}
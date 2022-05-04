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

            //Program generates random number between 1 and 10. User tries to quess the number after which program prompts if the number is higher or lower that the user quessed. 

            Random random = new Random();
            int randomNum = random.Next(1, 10);

            Console.WriteLine("Give a number between 1 and 10");
            int Usernum = int.Parse(Console.ReadLine());

            Console.WriteLine("the random number was {0}", randomNum);
            if (Usernum < randomNum)
            {
                Console.WriteLine("Your quess was too low");
            }
            else if (Usernum > randomNum)
            {
                Console.WriteLine("Your quess was too high");
            }
            else
            {
                Console.WriteLine("You were correct");
            }
        }
    }
}
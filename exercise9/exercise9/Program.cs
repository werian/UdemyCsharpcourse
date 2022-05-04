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
            //Program generate number between 1 and 10. User quesses the number until they quess the correct time.

            Random random = new Random();
            int randomNum = random.Next(1, 11);

           
            int userNum;
            do
            {
                Console.WriteLine("Enter number between 1 and 10");
                userNum = int.Parse(Console.ReadLine());

                if(userNum < randomNum)
                {
                    Console.WriteLine("Your quess was too low");

                }else if(userNum > randomNum){
                    Console.WriteLine("Your quess was too high");
                }
                else
                {
                    Console.WriteLine("You were correct");
                }

            } while (userNum != randomNum);
        }
    }
}
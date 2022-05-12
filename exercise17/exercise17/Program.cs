using exercise17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        /* program to uses class named Taxpayer. This class contains data fields for objects such as social security number, yearly gross income and tax owed. It also includes properties with get set
         * and read-only. Class will be used to calculate tax.
         * Main program will create 10 Taxpayer objects in an array.
         * 
        */
        static void Main(string[] args)
        {
            Taxpayer[] taxpayers = new Taxpayer[10];

            for (int i = 0; i < taxpayers.Length; i++)
            {
                taxpayers[i] = new Taxpayer();
                Console.WriteLine(" Enter payer #{0} SSN", i+1);
                taxpayers[i].SocialSecurityNum = Console.ReadLine();
                Console.WriteLine("Enter payer #{0} yearly income", i + 1);
                taxpayers[i].GrossIncome = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < taxpayers.Length; i++)
            {
                Console.WriteLine("Tax payer #{0}, SSN = {1}, Income = {2}, Tax owed = {3}", i+1, taxpayers[i].SocialSecurityNum, taxpayers[i].GrossIncome, taxpayers[i].TaxOwed);
            }
        }
    }
}
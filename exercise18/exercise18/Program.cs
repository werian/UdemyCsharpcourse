using exercise18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("Wash windows", 5, 15);
            Console.WriteLine("{0}, {1}, {2}, {3}",j1.JobDesc, j1.TimeToComplete, j1.HourlyRate, j1.TotalFee);
            Job j2 = new Job("Take out trash", 6, 10.5);
            Console.WriteLine("{0}, {1}, {2}, {3}", j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalFee);
            
            Job j3 = j1 + j2;
            Console.WriteLine("{0}, {1}, {2}, {3}", j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalFee);
        }



    }
}
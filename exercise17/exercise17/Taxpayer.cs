using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise17
{
    class Taxpayer
    {
        // objects
        private string socialSecurityNum;
        private double grossIncome;
        private double taxOwed;

        // properties
        public string SocialSecurityNum
        {
            get { return socialSecurityNum; }
            set { socialSecurityNum = value;}
        }
        public double GrossIncome
        {
            get { return grossIncome; }
            set
            {
                grossIncome = value;
                calcTaxOwed();
            }
        }

        public double TaxOwed
        {
            get { return taxOwed; }

        }

        //method
        private void calcTaxOwed()
        {
            if (grossIncome < 30000)
            {
                taxOwed = grossIncome * 0.15;
            }
            else
            {
                taxOwed = grossIncome * 0.28;
            }
        }


    }
}

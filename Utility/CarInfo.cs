using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPaymentApp.Utility
{
    public class CarInfo
    {
        public decimal price;
        public decimal downPayment;
        public decimal interestRate;
        public decimal loanAmount;
        public decimal monthlyPayment;
        public int loanTerm;

        public CarInfo() 
        {
            
        }

        public static int convertLoanTerm(string loanTermString)
        {
            if (loanTermString == "")
            {
                throw new Exception("invalid loan term!");
            }

            string[] parts = loanTermString.Split(' ');
            return int.Parse(parts[0]);
        }
        public decimal calculateMonthlyPayment()
        {
            return (loanAmount * interestRate) / (1 - (decimal)Math.Pow(1 + (double)interestRate, -loanTerm)
                        );
        }
    }
}

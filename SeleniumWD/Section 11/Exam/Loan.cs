using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.Section_11.Exam
{
    abstract class Loan
    {
        private int loanNumber;
        private string customerFName;
        private string customerLName;
        private double interestRate;
        private decimal loanAmount;
        private double yearsInLoanTerm;

        public Loan(int loanN, string customerFN, string customerLN, double interestR, decimal loanAmt, double yearsInLoan)
        {
            LoanNumber = loanN;
            CustomerFName = customerFN;
            CustomerLName = customerLN;
            InterestRate = interestR;
            LoanAmount = loanAmt;
            YearsInLoanTerm = yearsInLoan;
        }

       
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string CustomerFName { get => customerFName; set => customerFName = value; }
        public string CustomerLName { get => customerLName; set => customerLName = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public decimal LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double YearsInLoanTerm { get => yearsInLoanTerm; set => yearsInLoanTerm = value; }

        public override string ToString()
        {
            return "Customer:  " + CustomerFName + " " +
                    CustomerLName +
                    "\nLoan amount:  " + LoanAmount.ToString("C") +
                    "\nInterest Rate:  " + InterestRate.ToString("p2") +
                    "\nLoan Duration: " + YearsInLoanTerm;
        }

        public abstract decimal CalculateInterest();

    }
}

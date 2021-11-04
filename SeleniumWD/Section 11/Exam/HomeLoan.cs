using System;

namespace SeleniumWD.Section_11.Exam
{
    internal class HomeLoan : Loan
    {
        private string address;
        private int yearBuilt;
        private double squareFootage;
        decimal calculatedInterest;
        
        public string Address { get => address; set => address = value; }
        public int YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public double SquareFootage { get => squareFootage; set => squareFootage = value; }

        public HomeLoan(string address, int yearBuilt, double squareFootage, int loanN, string customerFN, string customerLN, double interestR, decimal loanAmt, int yearsInLoan) : base(loanN, customerFN, customerLN, interestR, loanAmt, yearsInLoan)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        public override string ToString()
        {
            return base.ToString() +
               "\nHome Loan Address: " + Address
           + "\n Calculated Interest :" + CalculateInterest().ToString("C");
        }

        public override decimal CalculateInterest()
        {
            var interestRate = Convert.ToDecimal(InterestRate);
            var numberOfPayments = Convert.ToDecimal(YearsInLoanTerm / 12);
            int adminFee = 5000;
            var loanPrincipal = LoanAmount + adminFee;
            return interestRate / numberOfPayments * loanPrincipal;
        }
    }
}
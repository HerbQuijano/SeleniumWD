using System;

namespace SeleniumWD.Section_11.Exam
{
    internal class AutoLoan : Loan
    {
        private int yearBuilt;
        private string model;
        private string make;
        private string color;

        public AutoLoan(int yearBuilt, string model, string make, string color, int loanN, string customerFN, string customerLN, double interestR, decimal loanAmt, double yearsInLoan) : base(loanN, customerFN, customerLN, interestR, loanAmt, yearsInLoan)

        {
            YearBuilt = yearBuilt;
            Model = model;
            Make = make;
            Color = color;
        }

        public int YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public string Color { get => color; set => color = value; }

        public override decimal CalculateInterest()
        {

            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(YearsInLoanTerm) / 12M) *
                (LoanAmount + 1000));
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nType of Car: " +
                YearBuilt + " " +
                Color + " " + Model
                + "\n Calculated Interest :" + CalculateInterest().ToString("C");
        }
    }
}
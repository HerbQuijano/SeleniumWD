namespace HousingTest
{
    internal class MultiUnit : Housing, IUnits
    {
        private string complexName;
        private int numberOfUnits = 0;
        private decimal rentAmtPerUnit = 0;

        public MultiUnit(string complexName, int numberOfUnits, decimal rentAmtPerUnit, string address, string bldType, string yearBuilt) : base(address, bldType, yearBuilt)
        {
            ComplexName = complexName;
            NumberOfUnits = numberOfUnits;
            RentAmtPerUnit = rentAmtPerUnit;
            Address = address;
            BldType = bldType;
            YearBuilt = yearBuilt;
        }

        public string ComplexName { get => complexName; set => complexName = value; }
        public int NumberOfUnits { get => numberOfUnits; set => numberOfUnits = value; }
        public decimal RentAmtPerUnit { get => rentAmtPerUnit; set => rentAmtPerUnit = value; }

        public override decimal ProjectedRentalAmt()
        {
            return rentAmtPerUnit * numberOfUnits * 12;
        }

        public int GetNumUnits()
        {
            return numberOfUnits;
        }

        public override string ToString()
        {
            //TBD
            return base.ToString() + "\nComplex Name: " + ComplexName + "\nNumber of Units: " + NumberOfUnits + "\nRent Amount per Unit: " + rentAmtPerUnit + ProjectedRentalAmt().ToString("C");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingTest
{
    class SingleFamily : Housing
    {
        decimal rentAmount = 0;
        double areaSize;
        int numberOfBedrooms = 0;
        int numberOfBathrooms = 0;
        bool isTherePorch = false;
        bool isThereGarage = false;

        public SingleFamily(decimal rentAmount, double areaSize, int numberOfBedrooms, int numberOfBathrooms, bool isTherePorch, bool isThereGarage, string address, string bldType, string yearBuilt) : base(address, bldType, yearBuilt)
        {
            RentAmount = rentAmount;
            AreaSize = areaSize;
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfBathrooms = numberOfBathrooms;
            IsTherePorch = isTherePorch;
            IsThereGarage = isThereGarage;
            Address = address;
            BldType = bldType;
            YearBuilt = yearBuilt;
        }

        public decimal RentAmount { get => rentAmount; set => rentAmount = value; }
        public double AreaSize { get => areaSize; set => areaSize = value; }
        public int NumberOfBedrooms { get => numberOfBedrooms; set => numberOfBedrooms = value; }
        public int NumberOfBathrooms { get => numberOfBathrooms; set => numberOfBathrooms = value; }
        public bool IsTherePorch { get => isTherePorch; set => isTherePorch = value; }
        public bool IsThereGarage { get => isThereGarage; set => isThereGarage = value; }

        public override decimal ProjectedRentalAmt()
        {
            return rentAmount * 12m;
        }

        public override string ToString()
        {
            //TBD
            return base.ToString() + "\nRent Amount: " + RentAmount.ToString("C") + "\nNumber of Bedrooms: " + NumberOfBedrooms + "\nNumber of Bathrooms: " + NumberOfBathrooms + "Expected Rent: " + ProjectedRentalAmt().ToString("C");
        }
    }
}

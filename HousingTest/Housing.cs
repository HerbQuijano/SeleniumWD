using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingTest
{
    class Housing
    {
        string address;
        string bldType;
        string yearBuilt;

        public Housing(string address, string bldType, string yearBuilt)
        {
            Address = address;
            BldType = bldType;
            YearBuilt = yearBuilt;
        }

        public string Address { get => address; set => address = value; }
        public string BldType { get => bldType; set => bldType = value; }
        public string YearBuilt { get => yearBuilt; set => yearBuilt = value; }

        public virtual decimal ProjectedRentalAmt()
        {
            return 0;
        }

        public override string ToString()
        {
            //TBD
            //return base.ToString();
            return "\nAddress: " + Address + "\nBuilding Type: " + BldType + "\nYear Built: " + YearBuilt;
                 
        }
    }
}

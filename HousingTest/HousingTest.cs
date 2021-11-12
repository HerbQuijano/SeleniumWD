using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HousingTest
{
    [TestClass]
    public class HousingTest
    {
        [TestMethod]
        public void SingleFamilyTest()
        {
            List<SingleFamily> singlefamilies = new List<SingleFamily>();

            singlefamilies.Add(new SingleFamily(250.55m, 28.55, 3, 2, true, false, "223 main road ave", "House", "1988"));
            singlefamilies.Add(new SingleFamily(120.56m, 55.95, 2, 1, false, true, "334 aag st", "Apartment", "1998"));
            singlefamilies.Add(new SingleFamily(280.59m, 67.45, 5, 2, false, false, "456 hell st", "House", "1955"));
            singlefamilies.Add(new SingleFamily(380.66m, 69.57, 3, 3, true, false, "335 once st", "Cabin", "1967"));
            singlefamilies.Add(new SingleFamily(180.56m, 98.34, 1, 1, false, false, "455 devil st", "House", "1997"));

            foreach (SingleFamily family in singlefamilies)
            {
                //family.ToString();
                Console.WriteLine(family);
            }
        }

        [TestMethod]
        public void MultiUnitsTest()
        {
            List<MultiUnit> multiUnits = new List<MultiUnit>();
            multiUnits.Add(new MultiUnit("Thoms", 6, 1134.88m, "223 Private road", "Apartment", "1986"));
            multiUnits.Add(new MultiUnit("Compton", 12, 565.76m, "44 gummy road", "House", "1967"));
            multiUnits.Add(new MultiUnit("Bowery", 14, 356m, "254 tongue road", "Factory", "1945"));
            multiUnits.Add(new MultiUnit("Blues", 22, 865.50m, "553 friendly road", "House", "1965"));
            multiUnits.Add(new MultiUnit("Mission", 12, 256.55m, "753 Newbie road", "Apartments", "1978"));

            foreach (MultiUnit multiUnit in multiUnits)
            {
                //multiUnit.ToString();
                Console.WriteLine(multiUnit);
            }
        }

        [TestMethod]
        public void CombinedTest()
        {
              List<Housing> housings = new List<Housing>();

            housings.Add(new SingleFamily(250.55m, 28.55, 3, 2, true, false, "223 main road ave", "House", "1988"));
            housings.Add(new SingleFamily(120.56m, 55.95, 2, 1, false, true, "334 aag st", "Apartment", "1998"));
            housings.Add(new SingleFamily(280.59m, 67.45, 5, 2, false, false, "456 hell st", "House", "1955"));
            housings.Add(new SingleFamily(380.66m, 69.57, 3, 3, true, false, "335 once st", "Cabin", "1967"));
            housings.Add(new SingleFamily(180.56m, 98.34, 1, 1, false, false, "455 devil st", "House", "1997"));

            housings.Add(new MultiUnit("Thoms", 6, 1134.88m, "223 Private road", "Apartment", "1986"));
            housings.Add(new MultiUnit("Compton", 12, 565.76m, "44 gummy road", "House", "1967"));
            housings.Add(new MultiUnit("Bowery", 14, 356m, "254 tongue road", "Factory", "1945"));
            housings.Add(new MultiUnit("Blues", 22, 865.50m, "553 friendly road", "House", "1965"));
            housings.Add(new MultiUnit("Mission", 12, 256.55m, "753 Newbie road", "Apartments", "1978"));

            foreach (Housing housing in housings)
            {
                Console.WriteLine("\nAddress: " + housing.Address);
                Console.WriteLine("Projected Rental amount: " + housing.ProjectedRentalAmt().ToString());
            }

        }
          

        
        
}
}
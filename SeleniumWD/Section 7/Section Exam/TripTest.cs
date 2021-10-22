using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_7.Section_Exam
{
    [TestClass]
    [TestCategory("Exam Section 7")]
    public class TripTest
    {
        [TestMethod]
        public void Miles_Per_Gallon()
        {
            Trip trip1 = new Trip("Cozumel", 80.00f, 12);
            Console.WriteLine($"Trip to: {trip1.Destination}");
            string substr = trip1.Calculate_MPG().ToString().Substring(0,3);
            Console.WriteLine($"Traveled {substr} miles per gallon");
            Assert.AreEqual(6.66, trip1.Calculate_MPG(), 0.1);
        }

        [TestMethod]
        public void Cost_Per_Mile()
        {
            Trip trip2 = new Trip("Chetumal", 700.00d, 90.00f);
            Console.WriteLine($"Trip to: {trip2.Destination}");
            string substr = trip2.Calculate_Cost_Per_Mile().ToString().Substring(0, 3);
            Console.WriteLine($"Costed ${substr} per mile");
            Assert.AreEqual(7.77, trip2.Calculate_Cost_Per_Mile(), 0.1);
        }

        [TestMethod]
        public void Test_ToString()
        {
            Trip trip3 = new Trip("Mahahual", 400.00f, 1200.00d, 10);
            Console.WriteLine(trip3.ToString());
            Assert.AreEqual("The trip was to Mahahual with a distance of 400 miles and a total cost of $1200 used 10 gallons", trip3.ToString());
        }

    }
}
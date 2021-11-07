using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_11.Exam
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Auto_Loan()
        {
            AutoLoan al1 = new AutoLoan(2009, "Vento", "Volkswager", "Silver", 5318, "Carlos", "Carrillo", .075, 12000, 4);
            var calculatedInterest = al1.CalculateInterest();
            Assert.AreEqual(2925, calculatedInterest);
            Console.WriteLine(al1);
        }

        [TestMethod]
        public void Test_Home_Loan()
        {
            HomeLoan hl1 = new HomeLoan("Calle 52 num 112", 1997, 70, 9254, "Guadalupe", "Cabrera", .035, 210000, 30);
            decimal calculatedInterest = hl1.CalculateInterest();
            Assert.AreEqual(3010, calculatedInterest);
            Console.WriteLine(hl1);
        }
    }
}
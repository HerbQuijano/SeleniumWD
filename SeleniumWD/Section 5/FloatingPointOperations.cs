using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_5
{
    [TestClass]
    [TestCategory("Doubles Operations")]
    public class FloatingPointOperations
    {
        static double number1;
        static double number2;

        [ClassInitialize]
        public static void InitializeDoubles(TestContext testContext)
        {
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Doubles_Addition()
        {
            double sum = number1 + number2;
            Assert.AreEqual(sum, 15.5);

        }
        [TestMethod]
        public void Test_Doubles_Substraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(difference, 5.5);

        }
        [TestMethod]
        public void Test_Doubles_Multiplication()
        {
            double multiplication = number1 * number2;
            Assert.AreEqual(multiplication, 52.5);
        }
        
        [TestMethod]
        public void Test_Doubles_Division()
        {
            double quotient = number1 / number2;
            Assert.AreEqual(quotient, 2.1);
        }
        [TestMethod]
        public void Test_Doubles_Modulus()
        {
            //Check if it is pair
            double remainder = number1 % number2;
            Assert.AreNotEqual(remainder, 0);
        }
    }
}

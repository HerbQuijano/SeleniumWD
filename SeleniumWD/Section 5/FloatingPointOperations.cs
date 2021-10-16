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
            number1 = 10d;
            number2 = 5d;
        }

        [TestMethod]
        public void Test_Doubles_Addition()
        {
            double sum = number1 + number2;
            Assert.AreEqual(sum, 15d);

        }
        [TestMethod]
        public void Test_Doubles_Substraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(difference, 5d);

        }
        [TestMethod]
        public void Test_Doubles_Multiplication()
        {
            double multiplication = number1 * number2;
            Assert.AreEqual(multiplication, 50d);
        }
        
        [TestMethod]
        public void Test_Doubles_Division()
        {
            double quotient = number1 / number2;
            Assert.AreEqual(quotient, 2d);
        }
        [TestMethod]
        public void Test_Doubles_Modulus()
        {
            double modulus = number1 % number2;
            Assert.AreEqual(modulus, 0);
        }
    }
}

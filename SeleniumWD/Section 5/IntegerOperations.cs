using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_5
{
    [TestClass]
    [TestCategory("Integer Operations")]
    public class IntegerOperations
    {
        //variables to hold integers
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set values of int variables
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            int difference = number1 - number2;
            Console.WriteLine(difference);
            Assert.AreEqual(difference, 5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int product = number1 * number2;
            Console.WriteLine(product);
            Assert.AreEqual(product, 50);
        }

        [TestMethod]
        public void Test_Division()
        {
            int quotient= number1 / number2;
            Console.WriteLine(quotient);
            Assert.AreEqual(quotient, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int modulus = number1 % number2;
            Console.WriteLine(modulus);
            Assert.AreEqual(modulus, 0);
        }
    }
}

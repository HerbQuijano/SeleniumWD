using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumWD.Section_9.Section_9_Quiz
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Calc_SquareRoot()
        {
            double result = MathFunctions.SquareRoot(25.00d);
            Assert.AreEqual(5.00d, result, 1);
        }

        [TestMethod]
        public void Sum_Int()
        {
            int result = MathFunctions.Sum(5, 4);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Sum_Double()
        {
            double result = MathFunctions.Sum(12.33, 3.45);
            Assert.AreEqual(15.78d, result, 0.1);
        }

        [TestMethod]
        public void Sum_Decimal()
        {
            string result = MathFunctions.Sum(34.678M, 23.556M).ToString();
            Assert.AreEqual("58.234", result);
        }
                
    }
}
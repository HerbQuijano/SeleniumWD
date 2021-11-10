using Microsoft.VisualStudio.TestTools.UnitTesting;
using section14;
using System;
using System.Collections.Generic;

namespace Section14
{
    [TestClass]
    public class AdvancedTest
    {
        [TestMethod]
        public void DelegateTest()
        {
            DelegateDemo.Main();
        }

        [TestMethod]
        public void ImplicitCasting()
        {
            Mammal mammal = new Cat();
            Animal animal = new Cat();
        }

        [TestMethod]
        public void ExplicitCasting()
        {
            double dPi = 3.141592654;

            int iValue = (int)dPi;
            Console.WriteLine(iValue);
        }

        [TestMethod]
        public void BoxCasting()
        {
            double dPi = 3.141592654;
            object oPi = (object)dPi;
        }

        private delegate int Del(int i);

        [TestMethod]
        public void TestLambda()
        {
            Del myDelegate = x => x * x;
            int j = myDelegate(5);
            Assert.AreEqual(j, 25);
        }

        [TestMethod]
        public void TestListLambda()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        delegate void TestDelegate(string s);
        [TestMethod]

        public void TestStatementLambda()
        {
            TestDelegate del = n =>
            {
                string s = n + " World";
                Console.WriteLine(s);
            };
            del("Hello");
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_8
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void TestWhileLoops()
        {
            //counter controlled repetition
            int number = 1;
            while (number < 11)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;

            Console.WriteLine("post increment value is: {0}", number++);
            Console.WriteLine("post increment value is: {0}", ++number);
            Console.WriteLine("post increment value is: {0}", number--);
            Console.WriteLine("post increment value is: {0}", --number);
        }
    }
}
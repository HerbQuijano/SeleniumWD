using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_5
{
    [TestClass]
    public class Section5Exam
    {
        private static int givenYear = 2032;

        [TestMethod]
        public void Test_Given_Year()
        {
            if (givenYear % 2 == 0)
            {
                if (givenYear % 4 == 0)
                {
                    if (givenYear % 100 != 0)
                    {
                        Assert.IsTrue(givenYear % 2 == 0 && givenYear % 4 == 0 && givenYear % 100 != 0);
                        Console.WriteLine($"The year {givenYear} is a Leap Year");
                    }
                    else
                    {
                        Assert.Fail($"The year {givenYear} is not a Leap Year");
                        return;
                    }
                }
                else
                {
                    Assert.Fail($"The year {givenYear} is not a Leap Year");
                    return;
                }
            }
            else if (givenYear % 2 != 0)
            {
                Assert.Fail($"The year {givenYear} is not a Leap Year");
            }
        }
    }
}
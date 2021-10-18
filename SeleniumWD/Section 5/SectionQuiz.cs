using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Exercise 1
//given the temperature in fahrenheit use a math
//expression to convert the temperature to celsius
//display a output string to the console that says
//The temp in F {given temp} is {temp} in C
//replacing the values as necessary in the string

//Exercise 2
//given the temperature in celsius use a math
//expression to convert the temperature to fahrenheit
//display a output string to the console that says
//The temp in C {given temp} is {temp} in F
//replacing the values as necessary in the string

namespace SeleniumWD.Section_5
{
    [TestClass]
    [TestCategory("Temperature Converters")]
    public class SectionQuiz
    {
        private static float tempC;
        private static float tempF;

        [ClassInitialize]
        public static void InitializeTemps(TestContext testContext)
        {
            tempC = 56;
            tempF = 70;
        }

        [TestMethod]
        [Description("Convert F to C")]
        public void Test_FtoC()
        {
            float resultC = ((tempF - 32) / 1.8f);
            Console.WriteLine($"The temp in °F {tempF} is {resultC} in °C");
            Assert.AreEqual(resultC, 21.11f, 0.01);
        }

        [TestMethod]
        [Description("Convert C to F")]
        public void Test_CtoF()
        {
            //float resultF = (tempC - 32f) / 1.8f;
            float resultF = ((tempC * 1.8f) + 32);

            Console.WriteLine($"The temp in °C {tempC} is {resultF} in °F");
            Assert.AreEqual(resultF, 132.8f, 0.1);
        }
    }
}
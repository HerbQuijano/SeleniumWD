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
        static float tempC;
        static float tempF;

        [ClassInitialize]
        public static void InitializeTemps(TestContext testContext)
        {
            tempC = 56;
            tempF = 70;
        }

        [TestMethod]
        [Description("Convert from F to C")]
        public void Test_FtoC()
        {
            float result = (tempF * 1.8f) + 32f;
            Console.WriteLine($"The temp in °F {tempF} is {result} in C");
            Assert.AreEqual(result, 158f, 0.001);
            
        }

        [TestMethod]
        [Description("Convert from C to F")]
        public void Test_CtoF()
        {
            float result = (tempC - 32f) / 1.8f;
            Console.WriteLine($"The temp in °C {tempC} is {result} in C");
            Assert.AreEqual(result, 13.33f, 0.01);

        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13.Quiz
{
    [TestClass]
    public class QuizTester
    {
        //modify test to catch three different exceptions:
        //ArithmeticException
        //FormatException
        //Exception
        //Use one try block to accomplish this task

        [TestMethod]
        public void Calculate_BMI()
        {
            //setup variables to calculate BMI
            string weight = "150";
            string heightInFeet = "6";
            string heightInInches = "72";
            BodyMassIndexCalculator bmi = null;

            //create instance of the BodyMassIndexCalculator, pass over all variables
            try
            {
                bmi = new BodyMassIndexCalculator
                (int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));

            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("Arithmetic problem - " + ex.Message);
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Format problem - " + ex.Message);

            }

            catch(Exception ex)
            {
                Console.WriteLine("System Exception - " + ex.Message);

            }

            //get result
            string result = bmi.ToString();

            //create Assertion
            Assert.AreEqual("BMI: 5.09", result);
        }
    }
}
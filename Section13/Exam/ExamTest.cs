using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13.Exam
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void TestExceptionWages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Indice esta fuera del rango del array");
            }
        }

        [TestMethod]
        public void TestCalculateResult()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        [TestMethod]

        public void TestNumber()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

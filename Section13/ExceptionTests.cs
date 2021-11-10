﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void Test_Exceptions()
        {
            int totalScores = 10;
            int countOfScores = 0;

            if (totalScores == 0 || countOfScores == 0)
            {

            }
            else
            {
                double average = totalScores / countOfScores;
            }
            
            
        }

        [TestMethod]
        public void Test_Division()
        {
            ExceptionHelper.DivisionTest();
        }

        [TestMethod]
        public void TestExceptionHandling()
        {
            try
            {
                ExceptionHelper.CheckState("MA");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        [TestMethod]

        public void TestExceptionUnhandled()
        {
            ExceptionHelper.CheckState("MA");
        }

        [TestMethod]
        public void TestCustomException()
        {
            try
            {
                ExceptionHelper.CheckStateCustom("MA");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

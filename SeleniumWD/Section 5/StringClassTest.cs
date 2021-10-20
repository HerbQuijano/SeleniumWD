using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_5
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Class()
        {
            string str = "This is the last time i do this";
            Console.WriteLine(str);
            string substr = str.Substring(4);
            Console.WriteLine(substr);
        }

        [TestMethod]
        public void Joining_Strings()
        {
            char[] chars = { 'H', 'E', 'L', 'L', 'O' };

            //pass a characters array
            string str = new string(chars);
            Console.WriteLine(str);
        }
    }
}
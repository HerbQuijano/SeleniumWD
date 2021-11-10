using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace Section14
{
    [TestClass]
    public class RegularExpressionsTest
    {
        [TestMethod]
        public void MatchEmail()
        {
            string[] addresses = {"AAAAAA@gmail.com", "AAAAAAAAaaa!@gmail.com"};

            //string pattern = @"^[0-9A-Z]([-.\w]*[0-9A-Z])*$";
            //string pattern = @"[^@ \t\r\n] +@[^@ \t\r\n]+\.[^@ \t\r\n]+";
            string pattern = @"[A-Za-z0-9_.-]+@([A-Za-z0-9_]+\.)+[A-Za-z]{2,4}";

            bool response = false;
            foreach (string address in addresses)
            {
                response = IsEmail(address, pattern);
                Console.WriteLine(response);
            }

            Assert.IsTrue(response);
        }

        public static bool IsEmail(string email, string pattern)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, pattern);

            }
            else
            {
                return false;
            }
        }

        [TestMethod]

        public void TestPhone()
        {
            string[] phones = { "+529993702052", "+52.9992.84.25.80", "9993702052", "(556)544.6698" };

            string pattern = @"^[\+]?[(]?[0-9]{2}[)]?[-s\.]?[0-9]{4}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}";
            string pattern2 = @"\(?[0-9]{3}\)?\-?[0-9]{3}\-?\.?[0-9]{4}";

            bool response = false;
            foreach (string phone in phones)
            {
                response = IsPhone(phone, pattern2);
                Console.WriteLine(response);

            }
            Assert.IsTrue(response);
        }

        public static bool IsPhone(string phone, string pattern)
        {
            if(phone != null)
            {
                return Regex.IsMatch(phone, pattern);
            }
            else
            {
                return false;
            }
        }
    }
}

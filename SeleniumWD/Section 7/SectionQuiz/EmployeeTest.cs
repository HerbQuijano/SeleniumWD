using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SeleniumWD.Section_7.SectionQuiz
{
    [TestClass]
    [TestCategory("Employee Class")]
    public class EmployeeTest
    {
        Employee emp = new Employee("Laureano", "Brizuela", "02/02/82", "Portero", "Administracion", 1, 2500.00);

        [TestMethod]
        public void TestEmployee1()
        {
            Assert.AreEqual(emp.ReturnName(), "Laureano Brizuela");
            Console.WriteLine("Pass, el nombre es " + emp.ReturnName());
        }

        [TestMethod]
        public void TestEmployee2()
        {
            Assert.AreEqual(emp.ReturnNameSorting(), "Brizuela, Laureano");
            Console.WriteLine("Pass, el nombre es " + emp.ReturnNameSorting());
        }
    }
}

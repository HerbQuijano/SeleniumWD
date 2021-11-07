using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumWD.Section_9
{
    [TestClass]
    public class MyEmployeeTest
    {
        [TestMethod]
        public void Test_EmployeeID()
        {
            MyEmployee employeeTest1 = new MyEmployee("Laszlo", "Lozla", 3000.00);
            MyEmployee employeeTest2 = new MyEmployee("Beto", "Beles", 6000.00);
            MyEmployee employeeTest3 = new MyEmployee("ddd", "hdfg", "Manager");

            employeeTest1.PayType(employeeTest1.Salary);
            employeeTest1.PayType("Employee");
            employeeTest1.PrintEmployee();

            employeeTest2.PayType("Manager");
            employeeTest2.PrintEmployee();

            employeeTest3.PrintEmployee();

            
        }
    }
}

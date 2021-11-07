using System;

namespace SeleniumWD.Section_9
{
    internal class MyEmployee
    {
        
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int EmployeeID
        {
            get;
            set;
        }

        public double Salary
        {
            get;
            set;
        }

        public string JobTitle
        {
            get;
            set;
        }

        public MyEmployee(string firstN, string lastN, double salary)
        {
            FirstName = firstN;
            LastName = lastN;
            Salary = salary;
        }
        public MyEmployee(string firstN, string lastN, string jobTitle)
        {
            FirstName = firstN;
            LastName = lastN;
            JobTitle = jobTitle;
        }


        public string PayType(double salary)
        {
            if (salary >= 4000)
            {
                return JobTitle = "Manager";
            }
            else
            {
                return JobTitle = "Employee";
            }
        }

        public int PayType(string jobTitle)
        {
            if (jobTitle == "Manager")
            {
                return EmployeeID = 1;
            }
            else if (jobTitle == "Employee")
            {
                return EmployeeID = 2;
            }
            else
            {
                Console.WriteLine("Undetermined");
                return 0;
            }
        }

        public void PrintEmployee()
        {
            Console.WriteLine("The " + FirstName + " " + LastName + " " + EmployeeID.ToString() + " and " + JobTitle + " " + Salary.ToString());
        }
    }
}
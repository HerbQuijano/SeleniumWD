namespace SeleniumWD.Section_7.SectionQuiz
{
    internal class Employee
    {
        //variables
        private int employeeNumber;

        private string firstName, lastName, dateOfHire, jobDescription, department;
        private double monthlySalary;

        //Constructors
        public Employee()
        {
        }

        //Constructor using properties
        public Employee(string firstN, string lastN, string dateOfHire, string jDescription, string department, int employeeNum, double salary)
        {
            FirstName = firstN;
            LastName = lastN;
            DateOfHire = dateOfHire;
            JobDescription = jDescription;
            Department = department;
            EmployeeNumber = employeeNum;
            MonthlySalary = salary;
        }

        //Accesors - Getter, Setter
        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfHire { get => dateOfHire; set => dateOfHire = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string Department { get => department; set => department = value; }
        public int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public double MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

        public string ReturnName()
        {
            return FirstName + " " + LastName;
        }

        public string ReturnNameSorting()
        {
            return LastName + ", " + FirstName;
        }
    }
}
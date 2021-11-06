using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_10
{
    class Professor : Person, ITraveler
    {
        private string employeeID;
        private string subject;

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Subject { get => subject; set => subject = value; }

        public Professor(string employID, string subj, string id, string firstN, string lastN, int age, DateTime dob) : base(id, firstN, lastN, age, dob)
        {
            EmployeeID = employID;
            Subject = subj;
            

        }

        public string GetDestination()
        {
            return "School";
        }

        public string GetStartLocation()
        {
            return "Home";
        }

        public double DetermineMiles()
        {
            return 56.00;
        }
    }

  
}

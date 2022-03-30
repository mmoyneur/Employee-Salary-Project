using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyneur_Course_Project_Part2
{
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string ssn;
        protected DateTime hireDate;
        protected Benefits benefits;

        //default constructor
        public Employee()
        {
            firstName = "Tom";
            lastName = "Brady";
            ssn = "unknown";
            hireDate = DateTime.MinValue;
        }
        //parameterized constructor
        
        public Employee(string fname, string lname, string ssn, DateTime hdate, Benefits benefits)
        {
            this.FirstName = fname;
            this.LastName = lname;                          
            this.SSN = ssn;
            this.HireDate = hdate;
            this.BenefitsPackage = benefits;
        }
        public override string ToString()
        {
            return firstName + " " + lastName+", SSN: " + ssn + ", HireDate: " + hireDate.ToShortDateString();
        }
        public virtual double CalculatePay()
        {
            return 0.0;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length > 0)
                    firstName = value;
                else
                    firstName = "unknown";
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length > 0)
                    lastName = value;
                else
                    lastName = "unknown";
            }
        }
        public string SSN
        {
            get { return ssn; }
            set
            {
                if(value.Length == 9 || value.Length == 11)
                    ssn = value;
                else
                    ssn = "unknown";
            }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                if(value.Year >=1950 && value.Year < DateTime.Now.Year + 1)
                    hireDate = value;
                else
                    hireDate = DateTime.MinValue;
            }
        }
        public Benefits BenefitsPackage
        {
            get { return benefits; }
            set { this.benefits = value; }
        }
    }
}

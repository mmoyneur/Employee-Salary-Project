using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyneur_Course_Project_Part2
{
    internal class Salary : Employee
    {
        //attribute
        private double annualSalary;
        //constructor

        public Salary() : base()
        {
            annualSalary = 0.0;

        }
        public Salary(string firstName, string lastName, string ssn, DateTime hiredate, Benefits benefits, double annualSalary)
            : base (firstName, lastName, ssn, hiredate, benefits)
        {
            AnnualSalary = annualSalary;
        }
        //methods

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + annualSalary.ToString("C2");
        }
        public override double CalculatePay()
        {
            return annualSalary / 26.0;
        }


        //property
        public double AnnualSalary
        {
            get { return annualSalary; }
            set
            {
                if (value > 0.0 && value < 10000000000.0)
                    annualSalary = value;
                else
                    annualSalary = 0.0;
            }
        }
    }
}

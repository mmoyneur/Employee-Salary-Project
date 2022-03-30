using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyneur_Course_Project_Part2
{
    internal class Hourly : Employee
    {
        //attributes
        private float hourlyRate;
        private float hoursWorked;
        //constructors

        public Hourly() : base ()
        {
            hoursWorked = 0.0f;
            hourlyRate = 0.0f;
        }
        public Hourly(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits, float hourlyRate, float hoursWorked)
         : base (firstName, lastName, ssn, hireDate, benefits)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }
        //methods
        public override string ToString()
        {
            return base.ToString() + ", Rate: "+ hourlyRate.ToString("C2") + ", Hours: " + hoursWorked.ToString();
        }
        public override double CalculatePay()
        {
            return hourlyRate * hoursWorked;
        }


        public float HourlyRate
        {
            get { return hoursWorked; }
            set
            {
                if (value > 0.0f && value < 1000.0f)
                    hourlyRate = value;
                else
                    HourlyRate = 0.0f;
            }
        }
        public float HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value > 0.0f && value < 140.0f)
                    hoursWorked = value;
                else
                    HoursWorked = 0.0f;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return ("total Emp Wage for company" + this.company + " is: " + this.totalEmpWage);
        }

    }
}

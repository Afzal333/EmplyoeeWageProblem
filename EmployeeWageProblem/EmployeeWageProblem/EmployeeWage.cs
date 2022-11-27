using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int Is_Present = 0,Is_Full_Time = 1,Is_Part_Time=2;
        Random random = new Random();

        private string company;
        private int empRatePerHour;
        private int numofWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
      

        public void Attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Present)
                Console.WriteLine("Emplyoee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        public EmployeeWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public void EmpWage()
        {
            int totalEmpHrs = 0, empHrs = 0,totalWorkingDays =0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numofWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:"+totalWorkingDays +" Emp Hrs : "+ empHrs);
            }
            int totalEmpWage = this.empRatePerHour * totalEmpHrs;
            Console.WriteLine("Total Emp Wage for Company : " + company +" is: "+ totalEmpWage);
        }

        public string toString()
        {
            return ("total Emp Wage for company" + this.company + " is: " + this.totalEmpWage);
        }

    }
}

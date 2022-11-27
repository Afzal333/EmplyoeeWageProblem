using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public const int Is_Present = 0,Is_Full_Time = 1,Is_Part_Time=2;

        private int numofComapny = 0;
        private CompanyEmpWage[] companyEmpWagesArray;

        Random random = new Random();

        public EmployeeWage()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }

        public void addCompanyWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWagesArray[this.numofComapny] = new CompanyEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
            numofComapny++;
        }
        public void Attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Present)
                Console.WriteLine("Emplyoee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        public void computeEmpWage()
        {
            for(int i= 0; i< numofComapny; i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.EmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].toString());
            }
        }


        private int EmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHrs = 0, empHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numofWorkingDays)
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
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

       

    }
}

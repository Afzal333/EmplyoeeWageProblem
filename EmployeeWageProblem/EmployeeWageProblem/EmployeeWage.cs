using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int Wage_Per_Hr = 20, Full_Day_Hr = 8, Is_Present = 0, Is_Full_Time = 1,Is_Part_Time=2, Part_Time_Hr =4;
        Random random = new Random();
        public void Attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Present)
                Console.WriteLine("Emplyoee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void EmpWage()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 3);
            if (empCheck == Is_Full_Time)
                empHrs = Full_Day_Hr;
            else if (empCheck == Is_Part_Time)
                empHrs = Part_Time_Hr;
            else
                empHrs = 0;
            dailyEmpWage = Wage_Per_Hr * empHrs;
            Console.WriteLine("Daily Emp Wage " + dailyEmpWage);
        }

    }
}

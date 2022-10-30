using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int Wage_Per_Hr = 20, Full_Day_Hr = 8, Is_Present = 0, 
            Is_Full_Time = 1,Is_Part_Time=2, Part_Time_Hr =4,Total_Working_Days = 20;
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
            int TotalEmpWage = 0, empHrs = 0;
            for (int i = 0; i < Total_Working_Days && empHrs < 100; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        empHrs += Full_Day_Hr;
                        break;
                    case Is_Part_Time:
                        empHrs += Part_Time_Hr;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }
            TotalEmpWage = Wage_Per_Hr * empHrs;
            Console.WriteLine("Total Emp Wage " + TotalEmpWage);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int Wage_Per_Hr = 20, Full_Day_Hr = 8, Is_Present = 0, 
            Is_Full_Time = 1,Is_Part_Time=2, Part_Time_Hr =4,Total_Working_Days = 20,Max_Hrs_In_Month = 10, Num_Of_Working_Days = 2;
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
            int totalEmpHrs = 0, empHrs = 0,totalWorkingDays =0;
            while (totalEmpHrs <=Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:"+totalWorkingDays +" Emp Hrs : "+ empHrs);
            }
            int totalEmpWage = Wage_Per_Hr * totalEmpHrs;
            Console.WriteLine("Total Emp Wage " + totalEmpWage);
        }

    }
}

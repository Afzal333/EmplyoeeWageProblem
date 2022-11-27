using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem Statement");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendance();
            employeeWage.EmpWage("DMart",20,2,10);
            employeeWage.EmpWage("Reliance", 10, 4, 20);
        }
    }
}

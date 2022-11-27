using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeWage Dmart = new EmployeeWage("Dmart", 20, 2, 10);
            //EmployeeWage Reliance = new EmployeeWage("Reliance", 20, 2, 10);
            //Dmart.EmpWage();
            //Console.WriteLine(Dmart.ToString());
            //Reliance.EmpWage();
            //Console.WriteLine(Reliance.ToString());

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.addCompanyWage("Dmart", 20, 2, 10);
            employeeWage.addCompanyWage("Reliance", 20, 2, 10);
            employeeWage.computeEmpWage();

        }
    }
}

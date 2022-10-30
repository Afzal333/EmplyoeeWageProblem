using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Emplyoee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

    }
}

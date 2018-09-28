using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructor
{
    public class Employee
    {
        public int salary;
        public Employee(int annualSalary)
        {
            salary = annualSalary;
        }
       // public Employee(int weeklySalary, int numberOfWeeks)
       // {
       //     salary = weeklySalary * numberOfWeeks;
       // }

            //rewritten the constructor above
        public Employee(int weeklySalary, int numberOfWeeks):this(weeklySalary * numberOfWeeks)
        {
            // this(weeklySalary * numberOfWeeks) = Employee(int annualSalary)
        }
    }
}

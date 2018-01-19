using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2000;
        public decimal GetAnnualSalary(int hourlyWage)=> hourlyWage * hoursInYear;
        public decimal GetHourlyWage(int annualSalary)=> annualSalary / hoursInYear;
        
    }
}

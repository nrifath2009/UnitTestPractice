using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestPractice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            SalaryCalculator sc =new SalaryCalculator();
            decimal annualSalary = sc.GetAnnualSalary(50);
            Assert.AreEqual(100000,annualSalary);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            SalaryCalculator sc = new SalaryCalculator();
            decimal hourlyWage = sc.GetHourlyWage(52000);
            Assert.AreEqual(26, hourlyWage);
        }
    }
}

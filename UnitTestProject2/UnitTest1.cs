using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            //Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 1;
            Employee e = new Employee();

            string expectedResponse = string.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                                                    "Paid for 40 hrs at $ {1}" +
                                                    "/hr = ${2}", weeklyHours, wage, salary);

            //Act
            //Assert
        }
    }
}

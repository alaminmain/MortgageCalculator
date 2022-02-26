using MortgageCalculator.API.Controllers;
using MortgageCalculator.API.Models.DAO;
using MortgageCalculator.API.Models.Enum;
using System;
using Xunit;

namespace MortgageCalculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMonthly()
        {
            //Arrange
            var Calculator = new CalculatorController();
            var data = new CalculatorObj(300000, 5, 20, 5, PaymentSchedule.Monthly);
            const double ans = 4529.1;

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            Assert.Equal(ans, result.Value);
        }
        /**
        Test for Accelerated Options
        **/
        [Fact]
        public void TestAccelerated()
        {
            //Arrange
            var Calculator = new CalculatorController();
            var data = new CalculatorObj(1000000, 10, 20, 5, PaymentSchedule.Accelerated);
            const double ans = 7831.57;

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            Assert.Equal(ans, result.Value);
        }

        /**
        Test for Biweekly Options
        **/
        [Fact]
        public void TestBiweekly()
        {
            //Arrange
            var Calculator = new CalculatorController();
            var data = new CalculatorObj(1000000, 10, 20, 5, PaymentSchedule.BiWeekly);
            const double ans = 8485.24;

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            Assert.Equal(ans, result.Value);
        }
    }
}

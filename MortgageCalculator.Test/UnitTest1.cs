using MortgageCalculator.API.Controllers;
using MortgageCalculator.API.Models.DAO;
using MortgageCalculator.API.Models.Enum;
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
            var data = new CalculatorObj(400000, 9, 30, 5, PaymentSchedule.Monthly);
            const double ans = 5812.34;

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
            var data = new CalculatorObj(2500000, 8, 30, 5, PaymentSchedule.Accelerated);
            const double ans = 16353.28;

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
            var data = new CalculatorObj(600000, 15, 25, 6, PaymentSchedule.BiWeekly);
            const double ans = 4748.52;

            //Act
            var result = Calculator.GetPaymentPerPaymentSchedule(data);

            //Assert
            Assert.Equal(ans, result.Value);
        }
    }
}

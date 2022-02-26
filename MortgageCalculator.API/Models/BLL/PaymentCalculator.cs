using MortgageCalculator.API.Models.DAO;
using MortgageCalculator.API.Models.Enum;
using System;

namespace MortgageCalculator.API.Models.BLL
{
    public class PaymentCalculator
    {
        //Property price
        private double P { get; set; }
        //Per payment schedule interest rate
        private double R { get; set; }
        //Total number of payments over amortization period
        private int N { get; set; }

        public PaymentCalculator()
        {
            
        }
        private double CalculateInterestRateForPaymentSchedule(double annualInterestRate, PaymentSchedule options)
        {
            return (annualInterestRate / 100) / (int)options;
        }
        private int totalPayments(PaymentSchedule options, int period)
        {
            return (int)options * period;
        }
        private double CalculateDownPayment(double downPaymentPercentage, double propertyPrice)
        {
            return propertyPrice * (downPaymentPercentage / 100);
        }


                
        public double CalculatePaymentPerPaymentSchedule(CalculatorObj input)
        {
            this.P = input.PropertyPrice - CalculateDownPayment(input.DownPaymentRate, input.PropertyPrice);
            this.R = CalculateInterestRateForPaymentSchedule(input.AnnualInterestRate, input.PaymentScheduleOptions);
            this.N = totalPayments(input.PaymentScheduleOptions, input.AmortizationPeriod);

            //Main Formula 
            double numerator = P * R * Math.Pow((1 + R), N);
            double denomnator = Math.Pow((1 + R), N) - 1;
            return Math.Round(numerator / denomnator, 2);
        }
    }
}

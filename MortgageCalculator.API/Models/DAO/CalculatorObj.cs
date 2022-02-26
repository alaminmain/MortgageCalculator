using MortgageCalculator.API.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.API.Models.DAO
{
    public class CalculatorObj
    {
        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double PropertyPrice { get; set; }

        [Required]
        [Range(0.0, 100, ErrorMessage = "The field {0} must be between {1} and {2}")]
        public double AnnualInterestRate { get; set; }

        [Required]
        [Range(5, 100, ErrorMessage = "The field {0} must be between {1} and {2}")]
        public double DownPaymentRate { get; set; }

        [Required]
        [Range(5, 30, ErrorMessage = "The field {0} must be between {1} and {2}")]
        public int AmortizationPeriod { get; set; }

        [Required]
        [EnumDataType(typeof(PaymentSchedule))]
        public PaymentSchedule PaymentScheduleOptions { get; set; }

        public CalculatorObj(double PropertyPrice, double AnnualInterestRate, double DownPaymentRate, int AmortizationPeriod, PaymentSchedule PaymentScheduleOptions)
        {
            this.PropertyPrice = PropertyPrice;
            this.AnnualInterestRate = AnnualInterestRate;
            this.DownPaymentRate = DownPaymentRate;
            this.AmortizationPeriod = AmortizationPeriod;
            this.PaymentScheduleOptions = PaymentScheduleOptions;
        }
        public CalculatorObj()
        {

        }
    }
}

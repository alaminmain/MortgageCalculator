using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MortgageCalculator.API.Models.BLL;
using MortgageCalculator.API.Models.DAO;

namespace MortgageCalculator.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase {
        /// <summary>
        /// Get payment per Payment Schedule
        /// </summary>
        /// <param name="input">From Query get Calculator Object</param>
        /// <returns>Get Double Result about payment per payment Schedule</returns>
        [HttpGet]
        public ActionResult<double> GetPaymentPerPaymentSchedule ([FromQuery] CalculatorObj input) {
            if (ModelState.IsValid) {
                var payment = new PaymentCalculator ();
                return payment.CalculatePaymentPerPaymentSchedule (input);
            } else {
                return BadRequest ();
            }
        }
    }
}
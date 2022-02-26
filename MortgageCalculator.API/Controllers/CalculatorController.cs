using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MortgageCalculator.API.Models.BLL;
using MortgageCalculator.API.Models.DAO;

namespace MortgageCalculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> GetPaymentPerPaymentSchedule([FromQuery] CalculatorObj input)
        {
            if (ModelState.IsValid)
            {
                var ans = new PaymentCalculator();
                return ans.CalculatePaymentPerPaymentSchedule(input);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

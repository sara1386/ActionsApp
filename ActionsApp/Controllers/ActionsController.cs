using Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActionsApp.Controllers
{
    using Service;
    using System.Net;

    [Route("api/[controller]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        ICalcService calcService;
        public ActionsController( ICalcService calcService)
        {
            this.calcService = calcService;
        }

        [HttpPost]
        public ActionResult<double> Calculate([FromBody] CalcData calcData)
        {
            try
            {
                if (!calcService.isValidAction(calcData.Operator))
                    return BadRequest("action not valid");
                if (!calcService.checkValidActionDivideByZero(calcData))
                    return BadRequest("cannot divide by 0");
                return calcService.calculate(calcData);
            }
            catch (Exception ex)
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                HttpContext.Response.WriteAsync(ex.Message);
                return 0;
            }
        }

      
    }
}

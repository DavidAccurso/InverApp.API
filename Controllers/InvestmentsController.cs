using InversiApp.API.Domain;
using InversiApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace InversiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentsController : ControllerBase
    {
        private readonly IinvestmentDomain _investmentDomain;

        public InvestmentsController(IinvestmentDomain iinvestment)
        {
            _investmentDomain = iinvestment;
        }

        [HttpPost]
        [Produces("application/json")]

        public IActionResult InsertInvestment(InvestmentDto insertInvestment)
        {
            //var investmentDto = JsonConvert.DeserializeObject<InvestmentDto>(insertInvestment);
            var a = HttpContext.Request.ContentType;
            var result = _investmentDomain.InsertInvestment(insertInvestment);
            return Ok(result);
        }

        [HttpGet("GetInvestments")]
        public IActionResult GetInvestments()
        {
            return Ok(_investmentDomain.GetInvestments());
        }

        [HttpGet("GetInvestmentById")]
        public IActionResult GetInvestmentById(int id)
        {
            return Ok(_investmentDomain.GetInvestmentById(id));
        }

        [HttpDelete]
        public IActionResult DeleteInvestment(int id)
        {
            return Ok(_investmentDomain.DeleteInvestment(id));
        }
    }
}

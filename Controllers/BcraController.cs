using InversiApp.API.Domain;
using InversiApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace InversiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BcraController : ControllerBase
    {
        private readonly IBcraDomain _bcraDomain;

        public BcraController(IBcraDomain bcraDomain)
        {
            _bcraDomain = bcraDomain;
        }

        [HttpGet(Name = "GetLastPrice")]
        public async Task<IActionResult> GetLastPrice()
        {
            BcraResponseDto response = await _bcraDomain.GetLastPrice();
            return Ok(JsonConvert.SerializeObject(response));
        }
    }
}

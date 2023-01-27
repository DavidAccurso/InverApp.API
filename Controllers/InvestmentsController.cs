﻿using InversiApp.API.Domain;
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
        public IActionResult InsertInvestment(InvestmentDto insertInvestment)
        {
            
            if (string.IsNullOrEmpty(insertInvestment.Asset))
            {
                return BadRequest("Please send the Asset name");
            }
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

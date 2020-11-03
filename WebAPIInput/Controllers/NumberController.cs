using Microsoft.AspNetCore.Mvc;
using System;
using WebAPIInput.Dto;
using WebAPIInput.Models;
using WebAPIInput.Services;

namespace WebAPIInput.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly INumberService numberService;

        public NumberController(INumberService numberService)
        {
            this.numberService = numberService;
        }

        // GET: api/number/1
        [Route("~/api/number/{id}")]
        [HttpGet("{id}")]
        public InputNumber GetByNumberId(int id)
        {
            return numberService.GetById(id).Result;
        }

        // POST: api/number
        [Route("~/api/number")]
        [HttpPost]
        public InputNumber AddNumberToDb(InputNumber number)
        {
            var id = this.numberService.Create(number).Result;

            return GetByNumberId(Convert.ToInt32(id));
        }

        // GET: api/sum
        [Route("~/api/sum")]
        [HttpPost]
        public string GetSum([FromBody] ListOfIndexDto listOfIndexNumbers)
        {
            return this.numberService.SumNum(listOfIndexNumbers.Indexes);
        }

    }
}

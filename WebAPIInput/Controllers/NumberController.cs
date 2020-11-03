using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPIInput.Dto;
using WebAPIInput.Models;
using WebAPIInput.Services;

namespace WebAPIInput.Controllers
{
    /**
     * REST Controller responsible for InputNumber related CRUD operations
     */
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly INumberService numberService;

        public NumberController(INumberService numberService)
        {
            this.numberService = numberService;
        }

        /**
         * Add an InputNumber
         * 
         * @param number    the number to add
         * @return the number added
         */
        // POST: api/number
        [Route("~/api/number")]
        [HttpPost]
        public InputNumber AddNumberToDb(InputNumber number)
        {
            return this.numberService.Create(number).Result;
        }

        /**
         * Retrieves the sum of 2 or more numbers
         * 
         * @param listOfIndexNumbers    the list DTO with database indexes that represent the numbers in database
         * @return the sum value
         */
        // GET: api/sum
        [Route("~/api/sum")]
        [HttpPost]
        public string GetSum([FromBody] ListOfIndexDto listOfIndexNumbers)
        {
            return this.numberService.SumNum(listOfIndexNumbers.Indexes);
        }

        /**
         * Retrieves a representation of the given InputNumbers
         * 
         * @return the list of InputNumbers (numbers in the database)
         */
        // GET: api/get
        [Route("~/api/get")]
        [HttpGet]
        public IEnumerable<InputNumber> GetAllNumbers()
        {
            return this.numberService.GetAll().Result;
        }

    }
}

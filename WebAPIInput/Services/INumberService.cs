using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIInput.Models;

namespace WebAPIInput.Services
{
    /**
     * Common interface for InputNumber services - provides methods to manage InputNumbers
     */
    public interface INumberService : IInputNumberService<InputNumber>
    {
        /**
         * Sums numbers present in Database
         * 
         * @param numberList    the database index of the numbers
         * @return the sum of the numbers
         */
        string SumNum(string[] numberList);
    }
}

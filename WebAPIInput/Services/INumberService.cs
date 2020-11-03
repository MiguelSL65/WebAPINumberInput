using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIInput.Models;

namespace WebAPIInput.Services
{
    public interface INumberService : IInputNumberService<InputNumber>
    {
        string SumNum(string[] numberList);
    }
}

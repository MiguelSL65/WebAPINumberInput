using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIInput.Models;
using WebAPIInput.Persistence;

namespace WebAPIInput.Services
{
    public class NumberService : INumberService
    {
        private InputNumberContext context;

        public NumberService(InputNumberContext context)
        {
            this.context = context;
        }

        public async Task<string> Create(InputNumber number)
        {
            this.context.Numbers.Add(number);
            await this.context.SaveChangesAsync();

            return number.ID.ToString();
        }

        public async Task<IEnumerable<InputNumber>> GetAll()
        {
            return await this.context.Numbers
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<InputNumber> GetById(int id)
        {
            return await this.context.Numbers
                .AsNoTracking()
                .FirstOrDefaultAsync(n => n.ID == id);
        }

        public string SumNum(string[] numberList)
        {
            var list = GetAll();
            double result = 0;
            int index = 0;

            if (numberList.Length == 0)
            {
                return null;
            }

            foreach(string id in numberList)
            {
                foreach (InputNumber num in list.Result)
                {
                    if (num.ID == Convert.ToInt32(id))
                    {
                        result += Convert.ToDouble(num.Num);
                        index++;
                    }
                }
            }

            return Convert.ToString(result);
        }

    }
}

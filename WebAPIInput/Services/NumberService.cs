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
    /**
     * An INumberService implementation
     */
    public class NumberService : INumberService
    {
        private InputNumberContext context;

        public NumberService(InputNumberContext context)
        {
            this.context = context;
        }

        /**
         * @see INumberService#Create(InputNumber) 
         */
        public async Task<InputNumber> Create(InputNumber number)
        {
            var num = this.context.Numbers.Add(number).Entity;
            await this.context.SaveChangesAsync();

            return num;
        }

        /**
         * @see INumberService#GetAll()
         */
        public async Task<IEnumerable<InputNumber>> GetAll()
        {
            return await this.context.Numbers
                .AsNoTracking()
                .ToListAsync();
        }

        /**
         * @see INumberService#GetById(int)
         */
        public async Task<InputNumber> GetById(int id)
        {
            return await this.context.Numbers
                .AsNoTracking()
                .FirstOrDefaultAsync(n => n.ID == id);
        }

        /**
         * @see INumberService#SumNum(string[])
         */
        public string SumNum(string[] numberList)
        {
            double result = 0;

            if (numberList.Length == 0)
            {
                return null;
            }

            foreach(string id in numberList)
            {
                result += Convert.ToDouble(GetById(Convert.ToInt32(id)).Result.Num);
            }

            return Convert.ToString(result);
        }

    }
}

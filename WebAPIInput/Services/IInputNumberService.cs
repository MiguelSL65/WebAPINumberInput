using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIInput.Services
{
    /**
     * Common interface for Number Data access
     * */
    public interface IInputNumberService<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Create(T model);
    }
}

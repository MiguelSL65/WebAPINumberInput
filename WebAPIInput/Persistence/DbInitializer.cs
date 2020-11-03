using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIInput.Services;

namespace WebAPIInput.Persistence
{
    public class DbInitializer
    {
        /**
         *  Ensures that Database has been initialized
         */
        public static void Initialize(InputNumberContext context, INumberService numberService)
        {
            context.Database.EnsureCreated();
        }
    }
}

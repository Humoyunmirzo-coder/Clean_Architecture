using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Services
{
 
    public  class Services
    {
        private DbContextt _dbContext;
        public Services()
        {
            _dbContext = new DbContextt();
        }
    }
}

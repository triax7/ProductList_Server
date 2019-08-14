using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ApplicationContext dbContext)
            : base(dbContext)
        { }
    }
}

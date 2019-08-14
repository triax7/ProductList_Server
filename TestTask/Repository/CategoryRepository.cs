using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(ApplicationContext dbContext)
            : base(dbContext)
        { }
    }
}

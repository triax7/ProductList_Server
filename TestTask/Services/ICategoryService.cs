using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels.CategoryViewModels;

namespace TestTask.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();
    }
}

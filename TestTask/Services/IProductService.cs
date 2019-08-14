using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels.ProductViewModels;

namespace TestTask.Services
{
    public interface IProductService
    {
        ProductListViewModel GetAll(int page);
        void Add(ProductAddViewModel productDTO);
    }
}

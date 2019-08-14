using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Repository;
using TestTask.Models;
using TestTask.ViewModels.ProductViewModels;
using TestTask.ViewModels;
using Microsoft.EntityFrameworkCore;
using TestTask.ViewModels.CategoryViewModels;

namespace TestTask.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductAddViewModel model)
        {
            Product product = new Product { Name = model.Name, CategoryId = model.CategoryId};
            _productRepository.Add(product);
        }

        public ProductListViewModel GetAll(int page)
        {
            var products = _productRepository.GetAll();
            var productList = new ProductListViewModel();
            productList.TotalProducts = products.Count();
            productList.Products = products.Skip((page - 1) * 10).Take(10)
                .Include(p => p.Category)
                .Select(p => new ProductViewModel {
                Id = p.Id,
                Name = p.Name,
                Category = new CategoryViewModel {Id = p.CategoryId, Name = p.Category.Name }
            });
            return productList;
        }
    }
}

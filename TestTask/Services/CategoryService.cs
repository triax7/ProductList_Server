using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;
using TestTask.Repository;
using TestTask.ViewModels.CategoryViewModels;

namespace TestTask.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = _categoryRepository.GetAll()
                .Select(c => new CategoryViewModel { Id = c.Id, Name = c.Name });

            return categories;
        }
    }
}

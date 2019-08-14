using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.ViewModels.CategoryViewModels;

namespace TestTask.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask.Services;
using TestTask.ViewModels;
using TestTask.ViewModels.ProductViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> Get([FromQuery] int page = 1)
        {
            var productsListView = _productService.GetAll(page);
            return Ok(productsListView);
        }

        [HttpPost]
        public ActionResult Post(ProductAddViewModel model)
        {
            _productService.Add(model);
            return Ok();
        }
    }
}

using CorePracticeApplication.DataBase.DomainModel;
using CorePracticeApplication.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CorePracticeApplication.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet("Product")]
        public IEnumerable<string> GetProduct()
        {
            var result = _productManager.GetProduct();
            return result.Select(x => x.Name).ToList();
        }

        [HttpGet("ProductById")]
        public Product GetProductById(int id)
        {
            var result = _productManager.GetProductById(id);
            return result;
        }
        [HttpGet("ProductByFilter")]
        public IEnumerable<string> GetProductByFilter(ProductFilterApiModel filterModel)
        {
            var result = _productManager.GetProductByFilter(filterModel);
            return result.Select(x => x.Name).ToList();
        }
    }
}
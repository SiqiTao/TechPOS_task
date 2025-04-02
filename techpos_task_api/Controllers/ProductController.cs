using Microsoft.AspNetCore.Mvc;
using techpos_task_api.Entities;
using techpos_task_api.Rules;

namespace techpos_task_api.Controllers
{
    [Route("api/product")]
    public class ProductController: ControllerBase
    {
        private readonly ProductRules _productRules;

        // dependency injection
        public ProductController(ProductRules productRules)
        {
            _productRules = productRules;
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productRules.GetProduct(id);

            if (product == null)
                return NotFound();

            return Ok(new { success = true, data = product });
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productRules.AddProduct(product);
            return Ok(new { success = true, data = product });
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productRules.UpdateProduct(product);
            return Ok(new { success = true, data = product });
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteProductById(int id)
        {
            var product = _productRules.GetProduct(id);
            if (product == null)
                return NotFound();

            _productRules.DeleteProduct(id);
            return Ok(new { success = true, data = id });
        }

        [HttpGet("test")]
        public string getInfo()
        {
            return ("Hello");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Data.Models;
using NLayer.Service;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAll();
            return new ObjectResult(response) { StatusCode= response.Status };
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> Get(int productId)
        {
            return await Get(productId);
        }
       
        [HttpPost]
        public async Task<IActionResult> Save(Product product)
        {
            return await Save(product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            return await Update(product);
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            return await Delete(productId);
        }
    }
}

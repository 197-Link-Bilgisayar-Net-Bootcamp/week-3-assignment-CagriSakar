using Microsoft.AspNetCore.Mvc;
using NLayer.Data.Models;
using NLayer.Service;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeaturesController :ControllerBase
    {
        private readonly ProductFeatureService _productFeatureService;

        public ProductFeaturesController(ProductFeatureService productFeatureService)
        {
            _productFeatureService = productFeatureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productFeatureService.GetAll();
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int productId)
        {
            return await Get(productId);
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductFeature product)
        {
            return await Save(product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductFeature product)
        {
            return await Update(product);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int productId)
        {
            return await Delete(productId);
        }
    }
}

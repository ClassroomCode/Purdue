using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm.WebAPI.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IRepository repository,
            ILogger<ProductController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("product")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _repository.GetAllProducts();
            
            /*
            var retVal = products.Select(p => 
                new { name = p.ProductName, price = p.UnitPrice });      
            */

            return Ok(products);
        }
    }
}

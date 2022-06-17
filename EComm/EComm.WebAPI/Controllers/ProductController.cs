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

        [HttpGet("product/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProduct(int id)
        {
            /*
            int i;
            if (!int.TryParse(id, out i)) {
                return BadRequest(new { Msg = "BAD ID" });
            }
            */

            var product = await _repository.GetProduct(id);
            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpPut("product/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            // TODO: Server-side validation

            try {
                await _repository.SaveProduct(product);
            }
            catch (ApplicationException ex) {
                return NotFound();
            }

            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace EComm.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository _repository;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IRepository repository,
            ILogger<ProductController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("products/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _repository.GetProduct(id);

            if (product == null) return NotFound();

            return View(product);
        }
    }
}

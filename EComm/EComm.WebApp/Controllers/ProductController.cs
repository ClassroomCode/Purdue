using EComm.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpGet("product/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _repository.GetProduct(id);
            if (product == null) return NotFound();

            return View(product);
        }

        [HttpGet("product/edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _repository.GetProduct(id);
            if (product == null) return NotFound();

            var suppliers = await _repository.GetAllSuppliers();

            var pvm = new ProductEditViewModel() {
                Id = product.Id,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                Package = product.Package,
                IsDiscontinued = product.IsDiscontinued,
                SupplierId = product.SupplierId
            };
            pvm.SupplierList = suppliers.Select(s =>
                new SelectListItem(s.CompanyName, s.Id.ToString()));

            return View(pvm);
        }

        [HttpPost("product/edit/{id}")]
        public async Task<IActionResult> Edit(int id, ProductEditViewModel pvm)
        {
            var product = new Product() {
                Id = pvm.Id,
                ProductName = pvm.ProductName,
                UnitPrice = pvm.UnitPrice,
                Package = pvm.Package,
                IsDiscontinued = pvm.IsDiscontinued,
                SupplierId = pvm.SupplierId
            };
            await _repository.SaveProduct(product);

            return RedirectToAction("Details", new { id = id });
        }
    }
}

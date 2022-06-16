using Microsoft.AspNetCore.Mvc.Rendering;

namespace EComm.WebApp.Models;

public class ProductEditViewModel
{
    public int Id { get; set; }

    public string ProductName { get; set; } = string.Empty;
    public Decimal? UnitPrice { get; set; }
    public string? Package { get; set; }
    public bool IsDiscontinued { get; set; }

    public int SupplierId { get; set; }

    public IEnumerable<SelectListItem> SupplierList { get; set; }
}

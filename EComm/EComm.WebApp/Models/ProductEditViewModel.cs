﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EComm.WebApp.Models;

public class ProductEditViewModel : IValidatableObject
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Product must have a name!")]
    public string ProductName { get; set; } = string.Empty;

    [Required]
    [Range(1, 500)]
    public Decimal? UnitPrice { get; set; }
  
    public string? Package { get; set; }
    public bool IsDiscontinued { get; set; }

    public int SupplierId { get; set; }

    public IEnumerable<SelectListItem> SupplierList { get; set; } = new List<SelectListItem>();

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var retVal = new List<ValidationResult>();
        if (ProductName.StartsWith("Q")) {
            retVal.Add(new ValidationResult("Name can't start with Q", 
              new List<string> { "ProductName" }));
        }
        return retVal;
    }
}

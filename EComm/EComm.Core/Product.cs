﻿namespace EComm.Core;

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = string.Empty;
    public Decimal? UnitPrice { get; set; }
    public string? Package { get; set; }
    public bool IsDiscontinued { get; set; }
    
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    public string DisplayText => $"{ProductName} [{UnitPrice:C}]";
}

﻿namespace EComm.Core;

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = string.Empty;
    public double? UnitPrice { get; set; }
    public string? Package { get; set; }
    public bool IsDiscontinued { get; set; }
    
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }
}
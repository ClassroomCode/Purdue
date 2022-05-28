using EComm.ConsoleApp;
using EComm.Infrastructure;

var r = new Repository();

var products = r.Products.Where(p => p.UnitPrice > 20)
    .OrderBy(p => p.UnitPrice)
    .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

/*
var products = from p in r.Products
               where p.UnitPrice > 20
               orderby p.UnitPrice
               select new { Name = p.ProductName, Price = p.UnitPrice };
*/

foreach (var p in products) {
    Console.WriteLine($"{p.Name} [{p.Price:C}]");
}


using EComm.Core;
using Microsoft.EntityFrameworkCore;

namespace EComm.Infrastructure;

public class Repository : DbContext, IRepository
{
    public DbSet<Supplier> Suppliers => Set<Supplier>();
    public DbSet<Product> Products => Set<Product>();

    public async Task<IEnumerable<Product>> GetAllProducts(bool includeSuppliers = false)
    {
        return (includeSuppliers ?
            await Products
                .Include(p => p.Supplier)
                .AsNoTracking()
                .ToListAsync()
            :
            await Products
                .AsNoTracking()
                .ToListAsync()
        );
    }

    public async Task<Product?> GetProduct(int id)
    {
        return await Products.SingleOrDefaultAsync(p => p.Id == id);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EComm;Integrated Security=True")
            .LogTo(Console.WriteLine);
    }
}

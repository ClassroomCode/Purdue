using EComm.Core;
using Microsoft.EntityFrameworkCore;

namespace EComm.Infrastructure;

public class Repository : DbContext
{
    public DbSet<Supplier> Suppliers => Set<Supplier>();
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EComm;Integrated Security=True");
    }
}

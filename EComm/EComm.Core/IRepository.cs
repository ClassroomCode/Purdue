namespace EComm.Core;

public interface IRepository
{
    Task<IEnumerable<Product>> GetAllProducts(bool includeSuppliers = false);
    Task<Product?> GetProduct(int id);

    Task<IEnumerable<Supplier>> GetAllSuppliers();

    Task SaveProduct(Product product);
}

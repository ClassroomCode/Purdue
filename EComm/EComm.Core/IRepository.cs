namespace EComm.Core;

public interface IRepository
{
    Task<IEnumerable<Product>> GetAllProducts(bool includeSuppliers = false);
    Task<Product?> GetProduct(int id);
}

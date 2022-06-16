namespace EComm.Core;

public interface IRepository
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product?> GetProduct(int id);
}

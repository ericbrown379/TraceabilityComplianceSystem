using System.Collections.Generic;
using System.Threading.Tasks;
using TraceabilityComplianceSystem.Models;

namespace TraceabilityComplianceSystem.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
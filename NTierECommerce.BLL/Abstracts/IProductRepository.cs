using NTierECommerce.Entities.Entities;

namespace NTierECommerce.BLL.Abstracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        Task<string> CreateProduct(Product product);

        Task<Product> GetProductById(int id);

        Task<string> UpdateProduct(Product product);
    }
}

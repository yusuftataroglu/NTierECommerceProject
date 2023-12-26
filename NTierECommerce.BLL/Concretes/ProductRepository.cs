using NTierECommerce.BLL.Abstracts;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepository<Product> _productRep;
        private readonly Product _product;

        public ProductRepository(IRepository<Product> productRep, Product product)
        {
            _productRep = productRep;
            _product = product;
        }
        public async Task<string> CreateProduct(Product product)
        {
            return await _productRep.Create(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRep.GetAll();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRep.GetById(id);
        }

        public async Task<string> UpdateProduct(Product product)
        {
            return await _productRep.Update(product);
        }
    }
}

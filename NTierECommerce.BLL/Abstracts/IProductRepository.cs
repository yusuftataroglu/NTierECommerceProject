﻿using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

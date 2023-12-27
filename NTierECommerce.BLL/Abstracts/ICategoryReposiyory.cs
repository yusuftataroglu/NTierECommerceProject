﻿using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Abstracts
{
    public interface ICategoryReposiyory
    {
        IEnumerable<Category> GetAllCategories();

        Task<Category> GetCategoryWithById(int id);

        Task<string> CreateCategory(Category entity);
        Task<string> UpdateCategory(Category entity);

        IEnumerable<Category> GetActiveCategories();
        IEnumerable<Category> GetPassiveCategories();

        Task<string> DeleteCategory(Category deleted);

    }
}

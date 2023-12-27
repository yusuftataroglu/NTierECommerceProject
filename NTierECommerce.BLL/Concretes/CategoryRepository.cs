using NTierECommerce.BLL.Abstracts;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class CategoryRepository : ICategoryReposiyory
    {
        private IRepository<Category> _categoryRep;


        public CategoryRepository(IRepository<Category> categoryRep)
        {
            _categoryRep = categoryRep;
        }

        public async Task<string> CreateCategory(Category entity)
        {
            return await _categoryRep.Create(entity);

        }

        public async Task<string> DeleteCategory(Category deleted)
        {
            return await _categoryRep.Delete(deleted);
        }

        public IEnumerable<Category> GetActiveCategories()
        {
            return _categoryRep.GetAllActive();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRep.GetAll();
        }

        public async Task<Category> GetCategoryWithById(int id)
        {
            return await _categoryRep.GetById(id);
        }

        public IEnumerable<Category> GetPassiveCategories()
        {
            return _categoryRep.GetAllPassive();
        }

        public async Task<string> UpdateCategory(Category entity)
        {
            return await _categoryRep.Update(entity);
        }


    }
}

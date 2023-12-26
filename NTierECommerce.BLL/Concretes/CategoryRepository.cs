using NTierECommerce.BLL.Abstracts;
using NTierECommerce.Entities.Entities;

namespace NTierECommerce.BLL.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private IRepository<Category> _categoryRep;

        public CategoryRepository(IRepository<Category> categoryRep)
        {
            _categoryRep = categoryRep;
        }

        //List
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRep.GetAll();
        }

        //Create
        public async Task<string> CreateCategory(Category category)
        {
            return await _categoryRep.Create(category);
        }

        //Read
        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRep.GetById(id);
        }

        //Update
        public async Task<string> UpdateCategory(Category category)
        {
            return await _categoryRep.Update(category);
        }


    }
}

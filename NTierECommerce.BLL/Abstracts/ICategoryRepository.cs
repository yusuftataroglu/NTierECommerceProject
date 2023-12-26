using NTierECommerce.Entities.Entities;

namespace NTierECommerce.BLL.Abstracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();

        Task<string> CreateCategory(Category category);

        Task<Category> GetCategoryById(int id);

        Task<string> UpdateCategory(Category category);



    }
}

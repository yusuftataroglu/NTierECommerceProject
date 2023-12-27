using Microsoft.AspNetCore.Mvc;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.BLL.Concretes;
using NTierECommerce.Entities.Entities;

namespace NTierECommerce.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryReposiyory _categoryRepository;

        public CategoryController(ICategoryReposiyory categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(_categoryRepository.GetAllCategories().Where(x=>x.Status!=Entities.Enums.DataStatus.Deleted).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Category model)
        {
            //todo: ViewModel içerisinde validation işlemleri tanımlanacak.
            var result = await _categoryRepository.CreateCategory(model);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            var model = await _categoryRepository.GetCategoryWithById(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            var result = await _categoryRepository.UpdateCategory(category);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> GetDetails(int id)
        {
            var model = await _categoryRepository.GetCategoryWithById(id);
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _categoryRepository.GetCategoryWithById(id);
            var result = await _categoryRepository.DeleteCategory(model);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }
    }
}

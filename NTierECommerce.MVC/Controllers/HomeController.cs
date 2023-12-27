using Microsoft.AspNetCore.Mvc;
using NTierECommerce.BLL.Abstracts;
using NTierECommerce.DAL.Context;
using NTierECommerce.Entities.Entities;
using NTierECommerce.MVC.Models;
using System.Diagnostics;

namespace NTierECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryReposiyory _categoryRepository;

        public HomeController(ILogger<HomeController> logger, ICategoryReposiyory categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            #region Test İşlemi

            //var categories = _categoryRepository.GetAllCategories();
            //var activeCategories = _categoryRepository.GetActiveCategories();
            //var passiveCategories = _categoryRepository.GetPassiveCategories();

            //Category category = new Category
            //{
            //    CategoryName = "Test 1",
            //    Description = "Test Description"
            //};

            //var result = await _categoryRepository.CreateCategory(category);

            //var updateCategory = await _categoryRepository.GetCategoryWithById(4);


            //updateCategory.CategoryName = "Güncellenen 1";
            //updateCategory.Description = "Güncellenen açıklama";
            //updateCategory.Status = Entities.Enums.DataStatus.Updated;

            //var updateREsult = await _categoryRepository.UpdateCategory(updateCategory);

            //var silinecekKategori =await _categoryRepository.GetCategoryWithById(4);

            //var deletedResult = await _categoryRepository.DeleteCategory(silinecekKategori); 
            #endregion



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
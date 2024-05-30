using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace RepositoryDesignPattern.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.TGetList());
        }

        [HttpGet]

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddCategory(Category category)
        {
            await _categoryService.TInsert(category);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var value = await _categoryService.TGetById(id);

            await _categoryService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public async Task<IActionResult> UpdateCategory(int id)
        {
            var value = await _categoryService.TGetById(id);

            return View(value);
        }

        [HttpPost ]

        public async Task<IActionResult> UpdateCategory(Category category)
        {
            await _categoryService.TUpdate(category);

            return RedirectToAction("Index");
        }
    }
}

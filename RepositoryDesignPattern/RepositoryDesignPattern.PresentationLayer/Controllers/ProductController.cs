using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace RepositoryDesignPattern.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var values =await _productService.TGetList();
            return View(values);
        }

        public async Task<IActionResult> Index2()
        {
            var values =await _productService.TProductListWithCategory();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            List<SelectListItem> values = (from x in await _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _productService.TInsert(product);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var value =await _productService.TGetById(id);
           await _productService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            List<SelectListItem> values = (from x in await _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value =await _productService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
           await _productService.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}

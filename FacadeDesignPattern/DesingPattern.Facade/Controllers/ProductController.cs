using Microsoft.AspNetCore.Mvc;
using DesingPattern.Facade.DAL;

namespace DesingPattern.Facade.Controllers
{
	public class ProductController : Controller
	{
		Context context = new Context();

		[HttpGet]
		public IActionResult AddNewProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddNewProduct(Product product)
		{
			context.Products.Add(product);
			context.SaveChanges();
			return RedirectToAction("ProductList");
		}
		public IActionResult ProductList()
		{
			var values = context.Products.ToList();
			return View(values);
		}
	}
}

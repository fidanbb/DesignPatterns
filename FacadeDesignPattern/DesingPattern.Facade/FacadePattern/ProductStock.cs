using DesingPattern.Facade.DAL;
	

namespace DesingPattern.Facade.FacadePattern
{
	public class ProductStock
	{
		Context context = new Context();
		public void StockDecrease(int id, int amount)
		{
			var value = context.Products.Find(id);
			value.ProductStock -= amount;
			context.SaveChanges();
		}
	}
}

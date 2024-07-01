using DesingPattern.Facade.DAL;

namespace DesingPattern.Facade.FacadePattern
{
	public class AddOrderDetail
	{
		Context context =new Context();
		public void AddNewOrderDetail(OrderDetail orderDetail)
		{
			context.OrderDetails.Add(orderDetail);
			context.SaveChanges();
		}
	}
}

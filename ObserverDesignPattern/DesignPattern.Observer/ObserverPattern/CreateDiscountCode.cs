using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscountCode:IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "MAGAZINEMARCH",
                DiscountAmount = 35,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}

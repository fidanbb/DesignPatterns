using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context=new Context();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
      
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Messages.Add(new Message
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Thank you very much for subscribing to our magazine newsletter," +
                "You can access our magazines from our website."
            });

            context.SaveChanges();
        }
    }
}

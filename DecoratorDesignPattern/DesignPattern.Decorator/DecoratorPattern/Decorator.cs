using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreator = "Admin";
            notifier.NotifierSubject = "Meeting";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "WhatsUp";

            _notifier.CreateNotify(notifier);
        }
    }
}

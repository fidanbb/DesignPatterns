using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageIDSubject(Message message)
        {
            if (message.MessageSubject == "1")
            {
                message.MessageSubject = "Meeting";
            }
            if (message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Meeting";
            }
            if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Weekly Review";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}

using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context =new Context();
        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }


        public void SendMessageByEncryptoContent(Message message)
        {
            message.MessageSender = "Team Leader";
            message.MessageReceiver = "Software Team";
            message.MessageContent = "Publish will be made at 17:00";
            message.MessageSubject = "Publish";

            string data = "";

            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}

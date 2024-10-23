namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"This text message was sent to you at {DateTime.Now}.\n{message}");
        }
    }
}

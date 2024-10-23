namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"This email was sent to you at {DateTime.Now}.\n{message}");
        }
    }
}

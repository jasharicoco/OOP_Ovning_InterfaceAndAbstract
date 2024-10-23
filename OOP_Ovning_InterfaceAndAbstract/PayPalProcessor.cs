namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Your payment of {amount.ToString("C")} is being handled by PayPal.");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Your payment of {amount.ToString("C")} is being refunded through PayPal. This takes 2-5 working days.");
        }
    }
}

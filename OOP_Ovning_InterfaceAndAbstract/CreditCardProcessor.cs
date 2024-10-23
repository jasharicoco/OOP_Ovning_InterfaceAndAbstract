using System;

namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Your payment of {amount.ToString("C")} is being processed.");
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Your payment of {amount.ToString("C")} is being refunded.");
        }
    }
}

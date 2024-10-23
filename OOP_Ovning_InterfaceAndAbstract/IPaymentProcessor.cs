namespace OOP_Ovning_InterfaceAndAbstract
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);

        void RefundPayment(decimal amount);
    }
}

namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class Smartphone : IChargable, IDisposable
    {
        public void Charge()
        {
            Console.WriteLine("Phone is charging.");
        }

        public void Dispose()
        {
            Console.WriteLine("Phone is disposed.");
        }
    }
}

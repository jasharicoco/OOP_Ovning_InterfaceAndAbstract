namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class ElectricDrive : IChargable, IDisposable
    {
        public void Charge()
        {
            Console.WriteLine("Unit charging.");
        }

        public void Dispose()
        {
            Console.WriteLine("Unit disposed.");
        }
    }
}

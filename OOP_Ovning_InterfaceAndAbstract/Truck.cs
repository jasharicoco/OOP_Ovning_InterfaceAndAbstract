namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck moving.");
        }

        public void Stop()
        {
            Console.WriteLine("Truck stopping.");
        }
    }
}

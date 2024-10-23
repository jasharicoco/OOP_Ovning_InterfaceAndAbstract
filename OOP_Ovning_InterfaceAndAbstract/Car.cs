namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car moving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopping.");
        }
    }
}

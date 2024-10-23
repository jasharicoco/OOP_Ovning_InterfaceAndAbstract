namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();

            car.Start();
            car.Stop();

            truck.Start();
            truck.Stop();

            var ECdrive = new ElectricDrive();
            var phone = new Smartphone();

            ECdrive.Charge();
            ECdrive.Dispose();

            phone.Charge();
            phone.Dispose();

            var FTemployee = new FullTimeEmployee();
            var contractor = new Contractor();

            FTemployee.Salary = 76000;
            contractor.Salary = 47000;

            Console.WriteLine($"Full Time Employee makes {FTemployee.CalculateSalary().ToString("C")} a month.");
            Console.WriteLine($"Contractor makes {contractor.CalculateSalary().ToString("C")} an hour.");

        }
    }
}

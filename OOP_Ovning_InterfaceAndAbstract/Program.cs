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

            var credit = new CreditCardProcessor();
            var paypal = new PayPalProcessor();

            credit.ProcessPayment(500);
            credit.RefundPayment(500);
            paypal.ProcessPayment(12000);
            paypal.RefundPayment(12000);

            var physical = new PhysicalProduct();
            var digital = new DigitalProduct();

            physical.ProductName = "Printer";
            physical.Price = 1520;
            physical.Weight = 5;
            physical.Dimensions = 3;

            digital.ProductName = "Portfolio";
            digital.Price = 1000000;
            digital.FileSize = 22;
            digital.Format = ".PDF";

            Console.WriteLine(physical.GetProductDetails());
            Console.WriteLine(digital.GetProductDetails());


            var email = new EmailSender();
            var sms = new SmsSender();

            email.SendMessage("How You Doin'? Email only plz. Thx!");
            sms.SendMessage("This is a Text Message!");

        }
    }
}

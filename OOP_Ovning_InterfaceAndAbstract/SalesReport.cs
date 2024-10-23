namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class SalesReport : Report
    {
        internal override string GenerateReport()
        {
            return "Sales are not looking too good at the moment. We are currently doing worse than ever. Shape up!";
        }
    }
}

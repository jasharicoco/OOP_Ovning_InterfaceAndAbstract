namespace OOP_Ovning_InterfaceAndAbstract
{
    internal abstract class Product
    {
        internal abstract string ProductName { get; set; }
        internal abstract decimal Price { get; set; }

        internal abstract string GetProductDetails();

    }
}

namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class DigitalProduct : Product
    {
        internal override string ProductName { get; set; }
        internal override decimal Price { get; set; }


        private int _fileSize;
        private string _format;


        public int FileSize { get; set; }
        public string Format { get; set; }

        internal override string GetProductDetails()
        {
            return $"{ProductName}: {Price.ToString("C")}, {FileSize} MB, {Format} format.";
        }
    }
}

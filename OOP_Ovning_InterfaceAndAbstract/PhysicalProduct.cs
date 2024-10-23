namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class PhysicalProduct : Product
    {
        internal override string ProductName { get; set; }
        internal override decimal Price { get; set; }


        private decimal _weight;
        private int _dimensions;


        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public int Dimensions { get; set; }

        internal override string GetProductDetails()
        {
            return $"{ProductName}: {Price.ToString("C")}, {Weight} kg, {Dimensions} dimensions.";
        }
    }
}

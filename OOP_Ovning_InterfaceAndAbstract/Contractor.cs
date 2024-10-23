namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class Contractor : Employee
    {
        private decimal _salary;

        internal decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 50000)
                {
                    value = 50000;
                }
                else if (value < 0)
                {
                    value = 20000;
                }
                _salary = value;
            }
        }

        internal override decimal CalculateSalary()
        {
            return Salary / 160;
        }
    }
}

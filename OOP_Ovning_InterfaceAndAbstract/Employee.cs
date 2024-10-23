namespace OOP_Ovning_InterfaceAndAbstract
{
    internal abstract class Employee
    {
        internal string Name { get; set; }
        internal int EmployeeID { get; set; }

        internal abstract decimal CalculateSalary();

    }
}

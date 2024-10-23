namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class DatabaseLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"Database has crashed a few times. Here's why: {message}.");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Information about database: {message}.");
        }
    }
}

namespace OOP_Ovning_InterfaceAndAbstract
{
    internal class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"Something went wrong. Read entry: {message}.");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Here's some information about your logg: {message}.");
        }
    }
}

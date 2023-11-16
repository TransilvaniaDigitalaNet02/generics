namespace GenericsExamples
{
    internal static class ConsoleLogger
    {
        public static void Log<TException>(TException exception) 
            where TException : Exception
        {
            if (exception is not null)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}

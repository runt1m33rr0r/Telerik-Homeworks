namespace Matrix
{
    using System;
    using Interfaces;

    public class ConsoleLogger<T> : ILogger<T>
    {
        public void LogData(T data)
        {
            Console.WriteLine(data);
        }
    }
}
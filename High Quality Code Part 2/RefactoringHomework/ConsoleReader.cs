namespace Matrix
{
    using System;
    using Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadInput()
        {
            string consoleInput = Console.ReadLine();
            return consoleInput;
        }
    }
}
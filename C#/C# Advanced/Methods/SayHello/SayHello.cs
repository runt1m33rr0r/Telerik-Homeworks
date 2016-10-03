using System;

class SayHello
{
    static void Main()
    {
        string name = Console.ReadLine();

        Hello(name);
    }

    static void Hello(string text)
    {
        Console.WriteLine("Hello, {0}!", text);
    }
}
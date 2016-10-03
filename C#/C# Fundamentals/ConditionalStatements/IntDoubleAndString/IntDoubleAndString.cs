using System;

class IntDoubleStr
{
    static void Main()
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "integer": Console.WriteLine(int.Parse(Console.ReadLine()) + 1); break;
            case "real": Console.WriteLine("{0:F2}", double.Parse(Console.ReadLine()) + 1); break;
            case "text": Console.WriteLine(Console.ReadLine() + "*"); break;
            default: break;
        }
    }
}
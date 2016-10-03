using System;
using System.Collections.Generic;

class ParseURL
{
    static void Main()
    {
        string input = Console.ReadLine();
        int lastIndex = 0;

        // get protocol
        List<char> protocol = new List<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ':')
            {
                break;
            }

            protocol.Add(input[i]);
            lastIndex = i;
        }
        input = input.Remove(0, lastIndex + 4);
        lastIndex = 0;
        Console.WriteLine("[protocol] = {0}", new string(protocol.ToArray()));

        //get server
        List<char> server = new List<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '/')
            {
                break;
            }

            server.Add(input[i]);
            lastIndex = i;
        }
        input = input.Remove(0, lastIndex + 1);
        lastIndex = 0;
        Console.WriteLine("[server] = {0}", new string(server.ToArray()));
        Console.WriteLine("[resource] = {0}", input);
    }
}
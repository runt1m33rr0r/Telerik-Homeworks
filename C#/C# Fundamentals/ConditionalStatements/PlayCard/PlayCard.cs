/* 
    Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8,
    9, 10, J, Q, K and A. Write a program that enters a string and prints "yes CONTENT_OF_STRING" if
    it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
*/

using System;

class PlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool validCard = false;

        foreach (var card in cards)
        {
            if (input == card)
            {
                validCard = true;
                break;
            }
        }

        Console.WriteLine(validCard ? "yes " + input : "no " + input);
    }
}
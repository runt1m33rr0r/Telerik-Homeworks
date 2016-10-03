using System;
using System.Collections.Generic;

class PrintDeck
{
    static void Main()
    {
        List<string> cards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string cardSign = Console.ReadLine();

        List<string> finalCards = new List<string>();
        for (int i = 0; i <= cards.IndexOf(cardSign); i++)
        {
            finalCards.Add(cards[i]);
        }

        for (int i = 0; i < finalCards.Count; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
        }
    }
}
using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = { "of Clubs", "of Spades", "of Hearts", "of Diamonds" };
        foreach (var card in cards)
        {
            foreach (var suit in suits)
            {
                Console.Write(card + " ");
                Console.Write(suit + " ");
            }
        }
    }
}


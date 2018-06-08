using System;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck testDeck = new Deck();
            // System.Console.WriteLine(testDeck.cards.Count);
            Player chris = new Player("Chris");
            System.Console.WriteLine(chris.hand.Count);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            chris.Draw(testDeck);
            
            System.Console.WriteLine(chris.hand.Count);
            
            Card idk = chris.Discard(100);
            System.Console.WriteLine(idk.stringVal);
        }
    }
}

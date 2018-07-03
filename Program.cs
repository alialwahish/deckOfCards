using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck= new Deck();
            Console.WriteLine("Dealing: "+myDeck.deal().ToString());
            myDeck.reset();
            myDeck.shuffle();
            Player ali = new Player("Ali");
            ali.draw();
            ali.draw();
            ali.draw();
            ali.discard(2);
        }
    }
}

using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {

        public List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] strVarArr = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suit = { "Clubs", "Spades", "Hearts", "Diamonds" };
            for (int s = 0; s < suit.Length; s++)
            {
                for (int i = 0; i < strVarArr.Length; i++)
                {
                    Card card = new Card(suit[s], strVarArr[i], i + 1);
                    cards.Add(card);
                }
            }
        }

        public Card deal()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return card;

        }

        public void reset()
        {
            cards = new List<Card>();
            string[] strVarArr = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suit = { "Clubs", "Spades", "Hearts", "Diamonds" };
            for (int s = 0; s < suit.Length; s++)
            {
                for (int i = 0; i < strVarArr.Length; i++)
                {
                    Card card = new Card(suit[s], strVarArr[i], i + 1);
                    cards.Add(card);
                }
            }
        }
        public List<Card> shuffle()
        {
            Random rand = new Random();
            Card[] shufArr = cards.ToArray();
            cards = new List<Card>();
            while (cards.Count < 52)
            {
                Card card = shufArr[rand.Next(0, shufArr.Length)];
                if (!cards.Contains(card))
                {

                    cards.Add(card);
                    Console.WriteLine("Loading .."+cards.Count);
                }
            }
            return cards;

        }
    
    }

}
using System;
using System.Collections.Generic;


namespace DeckOfCards{

    public class Player{
        public string name;
        public List<Card> hand=new List<Card>();
        Deck deck = new Deck();
        
        public Player(string name){
            this.name=name;
            deck.shuffle();
        }
        
        public Card draw(){
            Card card = deck.deal();
            this.hand.Add(card);

        return card;
        }
        public Card discard(int index){
            if(index<=hand.Count-1){
                Card card = hand[index];
                hand.RemoveAt(index);
                deck.cards.Add(card);
                return card;
            }
            else{
                return null;
            }

        }


    }
}
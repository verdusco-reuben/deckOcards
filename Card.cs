using System;
using System.Collections.Generic;

namespace demo2
{
    class Card
    {
        public string stringVal;
        public string suit;

        public int val;

        public Card(string strVal, string st, int v)
        {
            stringVal = strVal;
            suit = st;
            val = v;
        }
    }

    class Deck
    {
        public List<Card> cards  = new List<Card>();
        public Deck()
        {
            Reset();
        }
       public Card Deal()
       {
           Card tempCard = cards[0];
           cards.RemoveAt(0);
           return tempCard;
       }

       public void Reset()
       {
           List<Card> fakedeck = new List<Card>();
            string[] demosuits =  {"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] demostringVals = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            
            int i = 1;
            foreach(string suit in demosuits)
            {
                foreach(string val in demostringVals)
                {
                    Card newcard = new Card(val, suit, i++);
                    fakedeck.Add(newcard);
                    System.Console.WriteLine("Suit: "+newcard.suit+", Val: "+newcard.val);
                }
                i = 1;
            }

            // for(int x = 0 ; x < demosuits.Length; x++)
            // {
            //     for(int i = 0; i< demostringVals.Length; i++)
            //     {
            //         Card newcard = new Card(demostringVals[i], demosuits[x], i);
            //         fakedeck.Add(newcard);
            //         // System.Console.WriteLine("Suit: "+newcard.suit+", Val: "+newcard.val);  
            //     }             
            // }
            cards = fakedeck;
       }

        public void Shuffle()
        {
            Random _random = new Random();
            int n = cards.Count;
            for (int i = 0; i < n; i++)
            {
                int rand = i + _random.Next(n - i);
                Card temp = cards[rand];
                cards[rand] = cards[i];
                cards[i] = temp;
                System.Console.WriteLine(cards[i].suit);
            }
        }

    }
    class Player
    {
        public string name;

        public List<Card> hand;

        public Player(string n)
        {
            name = n;
            hand = new List<Card>();
        }
        public Card Draw(Deck curr_deck)
        {
            Card mycard = curr_deck.Deal();
            hand.Add(mycard);
            return mycard;
        }
        public Card Discard(int index)
        {
            if(index > hand.Count)
            {
                return new Card("null", "null", 0);
            }
            Card bad_card = hand[index];
            hand.RemoveAt(index);
            return bad_card;
        }

    }



}
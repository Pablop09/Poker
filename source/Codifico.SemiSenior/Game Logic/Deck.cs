using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codifico.SemiSenior.Game_Logic
{
    public class Deck : Card
    {
        // Total number of cards
        const int NUM_OF_CARDS = 52;

        // This is the deck of cards
        private Card[] deck; 

        //Deck of cards (constructor)
        public Deck()
        {
            deck = new Card[NUM_OF_CARDS]; 
        }

        //Get the current deck
        public Card[] getDeck
        {
            get { return deck; }
        }

        //Create a complete deck with number and suit
        public void SetDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(CARD_VALUE v in Enum.GetValues(typeof(CARD_VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyCard_Value = v };
                    i++;
                }
            }
            this.ShuffleDeck();
        }

        //This method shuffles all the cards created
        public void ShuffleDeck()
        {
            Random shuffle = new Random();
            Card temp;

            for (int i = 0; i <= 1000;  i++)
            {
                for (int j = 0; j < NUM_OF_CARDS; j++)
                {
                    int secondCardIndex = shuffle.Next(13);
                    temp = deck[j];
                    deck[j] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}
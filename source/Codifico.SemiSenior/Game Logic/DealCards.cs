using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codifico.SemiSenior.Game_Logic
{
    public class DealCards : Deck
    {
        //Array for player's hand
        private Card[] playerHand;

        //Array for sorted player's hand
        private Card[] sortedPlayerHand;

        //Constructor
        public DealCards()
        {
            this.playerHand = new Card[5];
            this.sortedPlayerHand = new Card[5];
        }

        //Method use for dealing the cards to the player
        public void Deal()
        {
            this.SetDeck(); //Create the deck and shuffle it
            this.getHand(); //Get player's hand
            this.sortCards(); // Sort player's hand
            this.evaluateHand(); //Method used to evaluate hand
        }

        //Get player's hand
        public void getHand()
        {
            //Asign 5 cards for the player
            for (int i = 0; i <5; i++)
            {
                this.playerHand[i] = this.getDeck[i];
            }
        }

        // Sort player's hand
        public void sortCards()
        {
            //LINQ query to order the player's hand
            var sortedDeck = from hand in playerHand
                             orderby hand.MyCard_Value
                             select hand;

            int j = 0;
            foreach (var item in sortedDeck.ToList())
            {
                this.sortedPlayerHand[j] = item;
                j++;
            }
        }

        //Method used to evaluate hand
        public void evaluateHand()
        {

        }
    }
}
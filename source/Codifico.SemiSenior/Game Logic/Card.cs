using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codifico.SemiSenior.Game_Logic
{
    public class Card
    {
        public enum SUIT
        {
            HEARTS,
            SPADES,
            DIAMONDS,
            CLUBS
        }

        public enum CARD_VALUE
        {
            TWO = 2,
            THREE = 3,
            FOUR = 4,
            FIVE = 5,
            SIX = 6,
            SEVEN = 7,
            EIGHT = 8,
            NINE = 9,
            TEN = 10,
            JACK = 11,
            QUEEN = 12,
            KING = 13,
            ACE = 14,
        }

        public SUIT MySuit { get; set; }
        public CARD_VALUE MyCard_Value { get; set; }
    }
}
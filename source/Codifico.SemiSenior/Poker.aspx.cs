using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Codifico.SemiSenior.Game_Logic;

namespace Codifico.SemiSenior
{
    public partial class Poker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Card1.ImageUrl = "~/Content/cards/upside_down_card.png";
            Card2.ImageUrl = "~/Content/cards/upside_down_card.png";
            Card3.ImageUrl = "~/Content/cards/upside_down_card.png";
            Card4.ImageUrl = "~/Content/cards/upside_down_card.png";
            Card5.ImageUrl = "~/Content/cards/upside_down_card.png";
        }

        protected void DealCards_Click(object sender, EventArgs e)
        {
            Deck mydeck = new Deck();
            mydeck.SetDeck();
            Card[] pablodeck = new Card[52];
            pablodeck = mydeck.getDeck;
        }
    }
}
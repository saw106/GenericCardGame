using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Player
{
    public Hand myHand;
    public Deck myDeck;

    public void drawCardFromDeck()
    {
        AbstractCard card = myDeck.draw();
        if (card != null)
        {
            myHand.addCard(card);
            //TODO Steven: deal with cards not going into the hand from size limit
        }
    }
}

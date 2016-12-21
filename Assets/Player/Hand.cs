using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Hand
{
    public List<AbstractCard> cards;
    public static int sizeLimit = 10;

    public Boolean addCard(AbstractCard newCard)
    {
        if (cards.Count >= sizeLimit)
        {
            return false;
        } else
        {
            cards.Add(newCard);
            return true;
        }
    }

    public void removeCard(AbstractCard card)
    {
        if (cards.Contains(card)) {
            cards.Remove(card);
        }
    }
}

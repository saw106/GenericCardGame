using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Deck
{
    public List<AbstractCard> cards;

    public AbstractCard draw()
    {
        if (cards.Count == 0)
        {
            return null;
        }
        Random rand = new Random();
        int indexToGrab = rand.Next(0, cards.Count);
        AbstractCard nextCard = cards.ElementAt(indexToGrab);
        cards.Remove(nextCard);
        return nextCard;
    }

    public void addCard(AbstractCard card)
    {
        cards.Add(card);
    }
}

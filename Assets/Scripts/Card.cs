using UnityEngine;
using System.Collections;

public enum CardType
{
    Study,
    Work,
    Social
};

public class Card : MonoBehaviour{
    public CardType type;
    public int level;
    public CardEffect effect;
    public Sprite front;
    public Sprite back;
    public Card(int level, CardType type)
    {
        this.level = level;
        this.type = type;
        effect = null;
    }
}

public class CardEffect
{
    public void play()
    {

    }
}

public class Deck
{
    Card[] cards;
    int size;
    public Card GetNextCard()
    {
        if(size == 0)
        {
            return null;
        }
        size--;
        return cards[size];
    }

    public void AddCard(Card card)
    {
        cards[size] = card;
        size++;
    }

    public void Shuffle()
    {
        for(int i = 0; i < size; i++)
        {
            int pos1 = Random.Range(0, size);
            int pos2 = Random.Range(0, size);
            //Swap pos1 and pos2
            Card tmp = cards[pos1];
            cards[pos1] = cards[pos2];
            cards[pos2] = tmp;
        }
    }
}
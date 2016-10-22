using UnityEngine;
using System.Collections;

public enum CardType
{
    Study,
    Work,
    Social
};

public class CardDetail
{
    public CardType type;
    public int level;
    public int id;
    public string name;
    public string text;

    public CardDetail(int id, CardType type, int level, string name, string text)
    {
        this.type = type;
        this.level = level;
        this.id = id;
        this.name = name;
        this.text = text;
    }
}

public interface ICard {
    CardDetail cardDetail
    {
        get;
    }

    void PlayCard(Player player);
}

public class Deck
{
    ICard[] cards;
    int size;
    public int maxSize = 100;

    public Deck ()
    {
        size = 0;
        cards = new ICard[maxSize];
    }

    public ICard GetNextCard()
    {
        if(size == 0)
        {
            return null;
        }
        size--;
        return cards[size];
    }

    public void AddCard(ICard card)
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
            ICard tmp = cards[pos1];
            cards[pos1] = cards[pos2];
            cards[pos2] = tmp;
        }
    }
}
using UnityEngine;
using System.Collections;
using System;

public class Card001 : ICard
{
    CardDetail ICard.cardDetail
    {
        get
        {
            CardDetail cd = new CardDetail(1, CardType.Study, 1, "Study...", "Just another hour of studying. . .");
            return cd;
        }

    }

    public void PlayCard(Player player)
    {
        player.knowledge += 2;
    }
}
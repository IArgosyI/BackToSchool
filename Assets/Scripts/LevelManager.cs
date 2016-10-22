using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager {
    public List<Character> friends;
    public Player player;

    public int turn;

    public void LevelStart()
    {
        player = Player.Load("Player1");
        turn = 0;
    }

    public void Save()
    {
        player.Save();
    }
}

public class LevelDetail
{
    int[] exam = new int[] {3,5,7,10};
    int[] minInt = new int[] { 20, 40, 60, 80 };
}


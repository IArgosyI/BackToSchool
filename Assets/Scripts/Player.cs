using UnityEngine;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class Character
{
    public string name;
    public Dictionary<string, int> relationships;
}

[Serializable]
public class Player : Character {
    //Status
    public int money;
    public int knowledge;

    //Traits
    public int intelligence;
    public int charisma;
    public int tolerance;
    public int luck;

    public Player(string name)
    {
        base.name = name;
        money = 0;
        knowledge = 0;
        relationships = new Dictionary<string, int>();

        intelligence = 0;
        charisma = 0;
        tolerance = 0;
        luck = 0;
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/player" + name + "Info.dat", FileMode.Create);

        bf.Serialize(file, this);
        file.Close();
    }

    public static Player Load(string name)
    {
        if(File.Exists(Application.persistentDataPath + "/player" + name + "Info.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/player" + name + "Info.dat", FileMode.Open);
            Player player = (Player)bf.Deserialize(file);
            return player;
        }

        return new Player(name);
    }
}

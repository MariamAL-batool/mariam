using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name;
    private int health;
    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set
        {
            health += value;
            if (health + value > 100)
                health = 100;
        }

    }
}

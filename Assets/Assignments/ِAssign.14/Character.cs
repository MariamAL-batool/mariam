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
            int result=health+value;
            if (result > 100)
                health = 100;
            else if (result<0)
            health=0;
            else
            health=result;

        }

    }
}

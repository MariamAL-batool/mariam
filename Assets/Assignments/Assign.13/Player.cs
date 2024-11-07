using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string playerName;
    int haelth;
    public static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        haelth = initialHealth;
        playerCount++;
    }
    public void Heal(int amount)
    {
        haelth = haelth + amount;
        if (haelth > 100)
        {
            haelth = 100;
        }
        Debug.Log(haelth);
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            haelth = 100;
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
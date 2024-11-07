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
        if (haelth + amount > 100)
        {

            Debug.Log("you acceded the limit so we reject this amount and the health now is : " + haelth);

        }
        else
        {
            haelth += amount;
            Debug.Log("the health is : " + haelth);
        }
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            Debug.Log("the health now is full !!");
            haelth = 100;
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log("the number of opjects you have created is"+playerCount);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health)
    {

    }
    public void Attack(Character anotherCharacter, int amount)
    {
        anotherCharacter.Health = (-amount);
        Debug.Log(Name + " attacked " + anotherCharacter.Name + " and dameged him by " + amount
        + " and the current heal for the player is " + anotherCharacter.Health);
        
    }
}

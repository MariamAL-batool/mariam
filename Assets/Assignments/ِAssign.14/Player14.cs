using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player14 : Character
{
        public Player14(string name, int health) : base(name, health)
    {
    }
    public void Heal(int amount)
    {
        Health = amount;
        Debug.Log(Name + " healed by " +amount +" and his health now is " + Health);
    }


    

}

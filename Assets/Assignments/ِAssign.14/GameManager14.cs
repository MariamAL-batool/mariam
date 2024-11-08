using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager14 : MonoBehaviour
{
    void Start()
    {
        Player14 ahmed=new Player14(" Ahmed ",70);
        Enemy monster=new Enemy(" the Monster ",90);
        Debug.Log("the player name is "+ahmed.Name+"and his health currently is "+ahmed.Health+" and his enemy is "
        +monster.Name+" and his health currently is "+monster.Health);
        ahmed.Heal(20);
        monster.Attack(ahmed,30);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player mariam=new Player();
        Player batool=new Player();
        mariam.InitializePlayer("mariam",70);
        batool.InitializePlayer("batool",80);
        mariam.Heal(40);
        mariam.Heal(20);
        mariam.Heal(true);
        Player.ShowPlayerCount();


    }

    
}

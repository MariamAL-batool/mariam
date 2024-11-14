using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Soldier soldier = new Soldier();
            Officer officer = new Officer("sobhi", 60, new Position(50, 50, 50));
            Character[] arr = new Character[] { soldier, officer };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].DisplayInfo();
            }
            officer.Attack(30,officer);


        }


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base("soldier", 100, new Position(10, 20, 30))
        {

        }
        public Soldier() : base("soldier", 100, new Position(10, 20, 30))
        {

        }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();


        }
    }
}
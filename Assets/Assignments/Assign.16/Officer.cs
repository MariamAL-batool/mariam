using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name,health,position)
        {

        }
        public Officer() : base("officer", 80, new Position(40, 40, 40))
        {

        }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();


        }

    }
}
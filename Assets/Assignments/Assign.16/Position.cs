using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public struct Position
    {
        float x;
        float y;
        float z;
        public Position(float x, float y, float z)
        {
            this.x = x;
            this.z = z;
            this.y = y;
        }
        public void printPosition()
        {
            Debug.Log("the position of this character is ( " + x + " , " + y + " , " + z + " ) ");
        }

    }
}
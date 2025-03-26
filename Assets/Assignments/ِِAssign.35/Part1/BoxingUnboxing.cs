using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class NewBehaviourScript : MonoBehaviour
    {


        void Start()
        {
            int health = 100;
            object healthBox = health;
            int healthUnboxed = (int)healthBox + 20;
            Debug.Log($"the original value :{health}");
            Debug.Log($"the boxed value :{healthBox}");
            Debug.Log($"the unboxed and modified value :{healthUnboxed}");

        }


        void Update()
        {

        }
    }
}

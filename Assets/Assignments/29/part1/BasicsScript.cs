using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            var a = 5;
            var str = "mariam";
            var boo = true;
            string result = a % 2 == 1 ? "odd" : "even";
            Debug.Log($"The number {a} is {result}");
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now);
            Debug.Log(System.DateTime.Now.Day);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
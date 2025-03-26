using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{

    public class BuiltInDelegatesExample : MonoBehaviour
    {

        void Start()
        {
            Action logMessage = () => Debug.Log("Hi guys,Im mariam!!nice to meet you,I aim to be a professional game developer just wait for me!");
            logMessage?.Invoke();

            Func<int, int> Square = (int a) => a * a;
            Debug.Log($"Square: {Square(5)}");

            Predicate<int> isEven = (int a) => a % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
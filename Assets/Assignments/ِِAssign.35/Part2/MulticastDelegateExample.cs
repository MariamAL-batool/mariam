using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{

    public delegate void MathOperation(int number);

    public class MulticastDelegateExample : MonoBehaviour
    {
        void Start()
        {

            MathOperation operation = null;// i had to initilized it before using += 
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            if (operation != null)
                operation.Invoke(5);

        }

        void DoubleNumber(int number) => Debug.Log($"Double:{number * 2}");
        void SquareNumber(int number) => Debug.Log($"Square:{Mathf.Pow(number, 2)}");
        void CubeNumber(int number) => Debug.Log($"Cube:{Mathf.Pow(number, 3)}");



    }
}
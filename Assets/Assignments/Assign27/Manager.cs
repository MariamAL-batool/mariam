using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class Manager : MonoBehaviour
    {
        void Start()
        {
            int a = 4;
            int b = 4;
            int c;
            AddingByCallingByValue(a);
            Debug.Log($"The number after ByCallingByValue is {a} ");

            AddingByCallingByReference(ref b);
            Debug.Log($"The number after ByCallingByReference is {b} ");

            UsingOut(out c);
            Debug.Log(c);

        }
        public void AddingByCallingByValue(int num)
        {
            num += 10;
        }
        public void AddingByCallingByReference(ref int num)
        {
            num += 10;
        }
        public void UsingOut(out int num)
        {
            num = 50;
        }


    }
}
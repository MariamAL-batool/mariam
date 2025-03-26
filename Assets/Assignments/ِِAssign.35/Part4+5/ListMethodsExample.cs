using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {

        void Start()
        {

            List<int> numbers = new List<int> { 4, 53, 2, 76, 2, 34, 56 };
            numbers.Sort((x,y)=>y.CompareTo(x));
            Debug.Log($"Sorted List (Descending): {string.Join(", ", numbers)}");

            List<int> numbers2= new List<int> {9,1,4,2,8,3};
            List<int> filteredNumbers=numbers2.FindAll(num => num % 2 == 0);
            Debug.Log(string.Join(", ", filteredNumbers));

        }
        void Update()
        {

        }
    }
}

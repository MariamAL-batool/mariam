using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assingment19
{
    public class grid : MonoBehaviour
    {
        float speed=8f;
        float deg=1f;
        float inc=0.1f;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            deg=deg+inc;
            transform.rotation=Quaternion.Euler(0,0,Time.deltaTime*speed+deg);


        }
    }
}

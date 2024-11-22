using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class theToy : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.rotation=Quaternion.Euler(new Vector3(0,90,0));

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.1f, 0, 0);
            transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
            transform.rotation=Quaternion.Euler(new Vector3(0,180,0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, 0, 0.1f);
            transform.rotation=Quaternion.Euler(new Vector3(0,270,0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0f, 0, -0.1f);
            transform.rotation=Quaternion.Euler(new Vector3(0,90,0));
        }
       
    }
}
   


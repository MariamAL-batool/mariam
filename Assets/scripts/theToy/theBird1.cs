using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBird1 : MonoBehaviour
{
    float deg = 0f;
    float inc = 0.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(deg,0,0));
        if (Mathf.Ceil(Time.time) % 2 != 0)
        {
            deg += inc;
        }
        if (Mathf.Ceil(Time.time) % 2 == 0)
        {
            deg -= inc;

        }
    }
}

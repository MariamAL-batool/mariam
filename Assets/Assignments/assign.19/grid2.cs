using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assingment19
{
public class grid2 : MonoBehaviour
{
    // Start is called before the first frame update
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
         transform.rotation=Quaternion.Euler(new Vector3(180,0,Time.deltaTime*speed+deg));
    }
}
}
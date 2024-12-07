using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBall : MonoBehaviour
{
    float speed =8f;
    void Start()
    {
       
    }
    
    

    void Update()
    {
        if(Mathf.Ceil(Time.time)%2!=0)
        {
            transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
        }
        if(Mathf.Ceil(Time.time)%2==0)
        {
            transform.position += new Vector3(-speed*Time.deltaTime, 0, 0);

        }
        
       
        
       
       
       
    }
}

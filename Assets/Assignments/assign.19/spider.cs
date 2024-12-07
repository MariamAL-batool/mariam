using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assingment19
{
public class spider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xnew=Mathf.Sin(Time.time*4);
        transform.position=new Vector3(transform.position.x,xnew*20f,transform.position.z);
    }
}
}

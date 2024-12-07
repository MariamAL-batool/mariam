using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assingment19
{
public class feet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xnew=Mathf.Sin(Time.time*20);
         transform.rotation=Quaternion.Euler(new Vector3(0,0,xnew*20f));

        
    }
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int Multiply(int x,int y){

            return x*y;
    }
        
    // Start is called before the first frame update
    void Start()
    {
        for (int i=1;i<=10;i++){
            int result=Multiply(5,i);
            Debug.Log("5 x "+i+"= "+result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

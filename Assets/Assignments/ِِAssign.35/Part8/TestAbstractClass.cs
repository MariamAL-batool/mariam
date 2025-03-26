using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAbstractClass : MonoBehaviour
{

    void Start()
    {
        DerivedClassExample ma = new DerivedClassExample();
        ma.PerformAction();
        ma.PrintInfo();

    }

}

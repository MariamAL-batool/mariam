using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils
{
    public static void DescribeItem<T>(T something)
    {
        string smth = "This item is a " + something;
        Debug.Log(smth);

    }
}

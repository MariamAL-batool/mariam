using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{

    void Start()
    {
        GameContainer<string> sobhi = new GameContainer<string>();
        sobhi.SetItem("Healing Potion");
        string theItem = sobhi.GetItem();
        Debug.Log("Stored item:" + theItem);
        GameUtils.DescribeItem(theItem);


    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    List<string> itemNames = new List<string>();
    public void AddItem(string item)
    {
        itemNames.Add(item);

    }
    public void ShowItems()
    {
        foreach (string n in itemNames)
        {
            Debug.Log(n);
        }
    }
    public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory result = new Inventory();
        foreach (string n in a.itemNames)
        {
            result.itemNames.Add(n);

        }
        foreach (string n in b.itemNames)
        {
            result.itemNames.Add(n);

        }
        return result;

    }

}

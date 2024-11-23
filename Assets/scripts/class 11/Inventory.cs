using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Inventory
{
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }
    public void Showitem()
    {
        foreach (string item in items)
        {
            Debug.Log(item);
        }
    }
    public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory combined = new Inventory();
        foreach (string item in inv1.items)
        {
            combined.AddItem(item);
        }
        foreach (string item in inv2.items)
        {
            combined.AddItem(item);
        }
        return combined;
    }

}

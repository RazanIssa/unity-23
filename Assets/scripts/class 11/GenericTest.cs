using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GenericTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> container = new GameContainer<string>();
        container.SetItem("Healing potion");
        string item = container.GetItem();
        Debug.Log("the stored item is " + item);
        string description = GameUtils.DescribeItem(item);
        Debug.Log(description);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameUtils
{
    public static string DescribeItem<T>(T something)
    {
        return "the item is " + something;
    }

}

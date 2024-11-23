using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potions = new Inventory();
        Inventory elixiers = new Inventory();


        potions.AddItem("healing potion" + "strength potion");
        elixiers.AddItem("Elexier" + "dark elixer");
        Inventory combineinventories = potions + elixiers;
        Debug.Log("combined inventory");
        combineinventories.Showitem();


    }


}

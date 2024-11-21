using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int health;
    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (health > 100)
                health = 100;
            else if (health < 0)
                health = 0;
            else health = value;
        }

    }

}

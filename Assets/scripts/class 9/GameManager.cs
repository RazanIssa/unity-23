using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    void Start()
    {
        Player player1 = new Player("subhi", 60);
        Enemy enemy1 = new Enemy("rana", 80);

        player1.Heal(10);
        enemy1.Attack(20);


    }

    // Update is called once per frame
    void Update()
    {

    }
}

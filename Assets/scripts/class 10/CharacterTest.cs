using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier soldier1;
        Officer officer;
        Character[] characterrs = new Character[2];

        void Start()
        {
            officer = new Officer("Jacop", 110, new Position(2, 9, 10));
            soldier1 = new Soldier();
            characterrs[0] = officer;
            characterrs[1] = soldier1;

            for (int i = 0; i < characterrs.Length; i++)
            {
                characterrs[i].DisplayInfo();

            }
            Debug.Log(soldier1.Health);
            officer.attack(20, soldier1, "shooting");
            Debug.Log(soldier1.Health);

        }

    }
}
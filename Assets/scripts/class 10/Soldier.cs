using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment16
{
    public class Soldier : Charecter
    {

        public Soldier(string soldiername, int soldierhealth, Position soldierposition) : base(soldiername, soldierhealth, soldierposition)
        {

        }
        public Soldier() : base()
        { }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }



    }
}
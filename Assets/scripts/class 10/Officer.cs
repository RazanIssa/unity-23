using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment16
{
    public class Officer : Charecter
    {
        public Officer(string officername, int officerhealth, Position ofiicerposition) : base(officername, officerhealth, ofiicerposition)
        {
        }
        public Officer() : base()
        { }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }



    }
}
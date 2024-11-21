using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

namespace assignment16
{
    public class Charecter
    {
        public string name;
        private int health;
        protected Position position;

        public Charecter(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }
        public Charecter() : this("", 100, new Position(0, 0, 0))
        {
        }

        public virtual void DisplayInfo()
        {
            Debug.Log(name + health);
            position.PrintPosition();
        }


        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0) health = 0;
                else if (value > 100) health = 100;
                else health = value;
            }

        }
        public void attack(int damage, Character target)
        {
            target.Health -= damage;
        }
        public void attack(int damage, Character target, string attacktyp)
        {
            Debug.Log(attacktyp);
            attack(damage, target);
        }




    }
}
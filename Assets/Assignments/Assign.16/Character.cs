using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                int result = health + value;
                Debug.Log("the old health for "+name+" is " + health);
                if (result > 100)
                {
                    Debug.Log("you acceded the limit by adding so we reject this amount and the health now is : " + health);
                }
                else if (result < 0)
                {
                    Debug.Log("you acceded the limit so we reject this amount and the health now is : " + health);
                }
                else
                {
                    health = result;
                    Debug.Log("the new health for "+name+" is " + health);
                }
            }
        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }
        public Character() : this("No name", 100, new Position(0, 0, 0))
        {

        }
        public virtual void DisplayInfo()
        {
            Debug.Log("the name of this character is " + name + " and his health is " + health);
            position.printPosition();

        }
        public void Attack(int damage, Character target)
        {
            target.Health = -damage;

        }
        public void Attack(int damage, Character target, string attackType)
        {
            target.Health = -damage;
            Debug.Log("the attack type is : " + attackType);

        }


    }
}
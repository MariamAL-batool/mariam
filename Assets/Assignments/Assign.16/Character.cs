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
                Debug.Log("the old health for "+name+" is " + health);
                if (value > 100)
                    health = 100;
                else if (value < 0)
                    health = 0;
                else
                    health = value;
                Debug.Log("the new health for "+name+" is " + health );
            }
        }
        //     set
        //     {
        //         Debug.Log("the old health for "+name+" is " + health);
        //         int newHealth = health + value;
        //         if (newHealth > 100)
        //         {
        //             newHealth =100;
        //         }
        //         else if (newHealth < 0)
        //         {
        //             newHealth =0;
        //         }
        //         health=newHealth;

        //             Debug.Log("the new health for "+name+" is " + health );

        //     }
        // }
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
            target.Health -= damage;

        }
        public void Attack(int damage, Character target, string attackType)
        {
            target.Health = -damage;
            Debug.Log("the attack type is : " + attackType);

        }


    }
}
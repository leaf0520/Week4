using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; set; }
    public string Ability { get; set; }

    public Player()
    {
        Health = 100;
        Ability = "Teleportation";
    }

    public void UseAbility()
    {
        if (Health > 0)
        {
            Console.WriteLine("You used your ability: " + Ability);
            Health -= 10;
            Console.WriteLine("Your health is now at " + Health);
        }
        else
        {
            Console.WriteLine("You have no health left. Returning you to class selection screen...");
            Health = 0;
        }
    }

}

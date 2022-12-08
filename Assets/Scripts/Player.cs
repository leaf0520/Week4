using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; set; }
    public string Class { get; set; }

    //constructor
    public Player()
    {
        Health = 100;
        Class = "";
    }

    //methods
    public void SelectClass(string selectedClass)
    {
        Class = selectedClass;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        //If the health reaches 0, reset the player
        if (Health <= 0)
        {
            Reset();
        }
    }


    private void Reset()
    {
        Health = 100;
        Class = "";
    }
}





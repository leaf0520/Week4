using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health { get; set; }
    public bool IsAlive { get; set; }

    public Enemy()
    {
        Health = 1;
        IsAlive = true;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            IsAlive = false;
        }
    }
}

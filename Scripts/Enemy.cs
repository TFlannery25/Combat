using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 250;

    //public GameObject deathEffect;

    // public GameObject healOrb;

    //public GameObject deathEffect

    

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        FindObjectOfType<KillCount>().AddKill(1);
        //Instantiate(deathEffect, transform.position, transform.rotation);
        //Instantiate(healOrb, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

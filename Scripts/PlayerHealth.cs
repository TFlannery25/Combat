using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int health;

    public Transform player;
    public float distance;
    public LayerMask mask;
    bool bulletHit;

    public HealthBar healthbar;

    public GameObject youDied;
    public RectTransform timer;
    public RectTransform timeSurvived;
    public RectTransform kills;
    public RectTransform killCounter;

    public GameObject newCam;
    public Transform oldCam;

    void Update()
    {
        bulletHit = Physics.CheckSphere(player.position, distance, mask);

        if (bulletHit)
        {
            Damaged(1);
            GetComponent<AutoDelete>();
        }
    }

    public void Damaged(int damage)
    {
        health -= damage;

        healthbar.SetHealth(health);
        
        if(health <= 0)
        {
            Death();
        }

    }

    public void Death()
    {
        FindObjectOfType<Timer>().EndTimer();
        Instantiate(newCam, oldCam.position, oldCam.rotation);
        Instantiate(youDied);
        timeSurvived.transform.Translate(500f, -450f, 0f);
        timer.transform.Translate(500f, -450f, 0f);
        kills.transform.Translate(500f, -450f, 0f);
        killCounter.transform.Translate(500f, -450f, 0f);
        Destroy(gameObject);

    }
}

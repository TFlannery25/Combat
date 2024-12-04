
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10;
    public float range = 100;

    public float fireRate = 15;

    public Camera cam;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    public GameObject audio;

    //private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(audio, transform.position, transform.rotation);
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(50);
            }
            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}

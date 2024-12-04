using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    bool alreadySpawned;
    public float timeBetweenSpawns;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!alreadySpawned)
        {
            Spawn();
            alreadySpawned = true;
            Invoke(nameof(ResetSpawn), timeBetweenSpawns);
        }
    }

    void Spawn()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }

    void ResetSpawn()
    {
        alreadySpawned = false;
    }
}

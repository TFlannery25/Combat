using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(deleteObject());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator deleteObject()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    public void BulletHit()
    {
        Destroy(gameObject);
    }
}

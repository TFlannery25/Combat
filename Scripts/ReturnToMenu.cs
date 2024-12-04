using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Return());
    }
    IEnumerator Return()
    {
        float time = 10;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

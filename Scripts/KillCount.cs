using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{

    public Text killCounter;

    public float kills;

    public void AddKill(int kill)
    {
        kills += kill;
    }

    public void Update()
    {
        killCounter.text = kills.ToString("0");
    }
    
}

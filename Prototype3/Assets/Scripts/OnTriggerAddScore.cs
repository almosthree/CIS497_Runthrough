﻿/*
* (Jerod Lockhart)
* (Prototype 3)
* (File makes the person score and records it on screen)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;


    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")&& !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}

﻿/*
* (Jerod Lockhart)
* (Prototype 2)
* (Shoots out the food to kill the animals with)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    // Set ref to inspector
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}

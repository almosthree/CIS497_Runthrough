/*
* (Jerod Lockhart)
* (Challenge 2)
* (Controls the player- allows him to fire dogs)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fetchRate = 1; //time player has to wait to fire
    private float nextFetch = 0; //Time since player has fired
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFetch)
        {
            nextFetch = Time.time + fetchRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}

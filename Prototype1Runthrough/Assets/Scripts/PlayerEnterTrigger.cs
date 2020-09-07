/*
* (Jerod Lockhart)
* (Prototype 1)
* (Obsolete Code that made the player trigger the trigger)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{    

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}

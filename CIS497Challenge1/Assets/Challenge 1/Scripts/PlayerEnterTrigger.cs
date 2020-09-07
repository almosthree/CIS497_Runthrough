/*
* (Jerod Lockhart)
* (Challenge 1)
* (Controls the triggers for the player to score)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to trigger zone
public class PlayerEnterTrigger : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }

}

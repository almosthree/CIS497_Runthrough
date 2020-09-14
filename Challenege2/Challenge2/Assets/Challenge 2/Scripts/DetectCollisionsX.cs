/*
* (Jerod Lockhart)
* (Challenge 2)
* (Detects if the ball hits the dog and destroys the ball if it does.
* Then gives a point.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.score++; //score ++ if dog catches
        Destroy(gameObject);
    }
}

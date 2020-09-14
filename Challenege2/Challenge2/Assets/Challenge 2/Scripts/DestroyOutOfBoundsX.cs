/*
* (Jerod Lockhart)
* (Challenge 2)
* (Destroys the dogs and the balls when either goes out of bounds. 
* If a ball goes out of bounds takes away a health point.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            ScoreManager.health--; //health -- if ball drops
        }

    }
}

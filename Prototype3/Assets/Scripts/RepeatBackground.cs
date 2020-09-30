/*
* (Jerod Lockhart)
* (Prototype 3)
* (Moves the background)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //save starting position
        startPosition = transform.position;

        //set repeat width half 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //if background farther than repeat width it repeat
        if(transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}

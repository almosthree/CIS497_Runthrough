/*
* (Jerod Lockhart)
* (Prototype 2)
* (Makes the food go away when it goes off screen, and causes the 
* animals to make you lose health once they go off screen)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        //sperating food from animals going out of bounds
        //Food
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBound)
        {//grab health system and tag get damage
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    }
}

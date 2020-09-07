/*
* (Jerod Lockhart)
* (Prototype 1)
* (Makes sure that if you fall you lose)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseOnFall : MonoBehaviour
{
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}

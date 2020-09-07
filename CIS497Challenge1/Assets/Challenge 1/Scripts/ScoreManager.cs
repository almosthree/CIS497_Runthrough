/*
* (Jerod Lockhart)
* (Challenge 1)
* (Controls the main game- allows resets, winning and losing)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
        Time.timeScale = 0;

    }
    // Update is called once per frame
    void Update()
    {
        //starts the game off paused so that it just doesn't instantly start moving
        textbox.text = "Press Space to begin!";
        //once called plane starts moving
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
        if (Time.timeScale == 1)
        {
            if (!gameOver)
            {
                textbox.text = "Score: " + score;
            }
            //win con= 5 or more
            if (score >= 5)
            {
                won = true;
                gameOver = true;
            }

            if (gameOver)
            {
                if (won)
                {
                    textbox.text = "You win! \nPress R to Try Again!";
                }
                else
                {
                    textbox.text = "You lose! \nPress R to Try Again!";
                }
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}

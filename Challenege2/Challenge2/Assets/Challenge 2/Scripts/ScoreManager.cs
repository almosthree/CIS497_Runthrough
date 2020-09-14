/*
* (Jerod Lockhart)
* (Challenge 2)
* (Controls the scoring of the game and allows a reset if you lose or win)
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
    public static int health = 3;

    public Text scoreCard;
    public Text healthPool;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
        health = 3;
    }
    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            scoreCard.text = "Score: " + score;
            healthPool.text = "Health: " + health;
        }
        //win con= 5 or more
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (health <= 0)
        {
            gameOver = true;
        }


        if (gameOver)
        {
            if (won)
            {
                scoreCard.text = "You win! \nPress R to Try Again!";
                healthPool.text = "";
            }
            else
            {
                scoreCard.text = "You lose! \nPress R to Try Again!";
                healthPool.text = "";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}

/* Jerod Lockhart
 * Assignment 8
 * Manages Game events
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActve ;
    public Button restartButton;
    private int score;

    public GameObject titleScreen;
    

    private float spawnRate = 1.0f;


    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActve = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore(int _score)
    {
        score += _score;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {

        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActve = false;
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActve)
        {
            //wait one sec
            yield return new WaitForSeconds(spawnRate);

            //spawn a random prefab
            int index = Random.Range(0, targets.Count);


            Instantiate(targets[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

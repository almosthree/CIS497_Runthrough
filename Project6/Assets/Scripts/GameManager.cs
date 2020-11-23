using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    public int score;

    //variable to keep track of what level you're on
    private string CurrentLevelName = string.Empty;

    #region This code makes this class a singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //make sure this persists 
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second" + 
                "instance of singleton Game Manager");
        }
    }
    #endregion
//methods to load and unload screens
public void loadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level" + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

public void UnloadLevel(string levelName)
{
    AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
    if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level" + levelName);
            return;
        }
    }
}

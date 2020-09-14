/*
* (Jerod Lockhart)
* (Prototype 2)
* (Causes the animals to randomly spawn)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //drag the prefabs to spawn onto this array
    public GameObject[] prefabsToSpawn;
    public HealthSystem healthSystem;

    //Variables for spawn position
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    
    // Update is called once per frame
    void Update()
    {
       // if(Input.GetKeyDown(KeyCode.S))
        //{
            /*  //step 1:
             //Spawn 0th prefab at top of screen
             //Instantiate(prefabsToSpawn[0], new Vector3(0, 0, 20), prefabsToSpawn[0].transform.rotation);

             //Step 2:
             //Pick random index between 0 and legnth of array
             int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

             //Spawn the randomly selected prefab
             Instantiate(prefabsToSpawn[prefabIndex], new Vector3(0, 0, 20), prefabsToSpawn[prefabIndex].transform.rotation);
         */
            //Step 4
            //Move SpawnRandomPrefab to it's on method
       //     SpawnRandomPrefab();
    //    }
    }

    void Start()
    {
        //Step 5:
        //Calls for the method over and over
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        //getreference to the health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //step 6:
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //adds 3 second delay before first prefab
        yield return new WaitForSeconds(3f);

        //Countine to spawn while the game is not over
        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            yield return new WaitForSeconds(1.5f);
        }
    }

    void SpawnRandomPrefab()
    { //generate index
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate spawn position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);

    }

    public bool gameOver = false;
}

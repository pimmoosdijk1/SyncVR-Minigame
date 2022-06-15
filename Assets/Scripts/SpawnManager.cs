using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs; //make list of animal prefabs
    private float spawnrangeX = 20;
    private float spawnPosZ = 20;

    //private float startDelay = 2; //DECOMMENT FOR CONSTANT SPAWNING

    public double spawnInterval = 2.5; // how often do animals spawn
    public float currentSpawnTime = 0;
 
    public float  bigCountdown = 10; // time it takes for spawninterval to update
    public float currentBigTime = 0; 
 
    void Update()
    {
        currentSpawnTime += Time.deltaTime; // counting up until spawninterval is reached
        currentBigTime += Time.deltaTime; //couting until bigtime is reached

        if (currentSpawnTime >= spawnInterval) //if current spawn time is higher than spawninterval
        {
            SpawnRandomAnimal(); //spawn animal
            currentSpawnTime = 0; //set current spawn time back to 0
        }

        if (currentBigTime >= bigCountdown && spawnInterval >1.5f) //if big time has passed, and spawn interval is more than 1.5
        {
            spawnInterval -= 0.1; //shorten the spawninterval with '' when big time has reached 10
            currentBigTime = 0; //set big time back to 0
        }
    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); ////// DECOMMENT TO HAVE CONSTANT SPAWNING
    //}

    
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnrangeX, spawnrangeX), 0, spawnPosZ); //Create random position within spawn range X(-20,20) and Z(20)


        int animalIndex = Random.Range(0, animalPrefabs.Length); //Pick random animal from list



        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); //instantiate animal from list at randomly created spawn position

    }   
}

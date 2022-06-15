using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnrangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    
    void SpawnRandomAnimal()
    {
        //Create random position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnrangeX, spawnrangeX), 0, spawnPosZ);

        //Pick random animal from list
        int animalIndex = Random.Range(0, animalPrefabs.Length);


        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }   
}

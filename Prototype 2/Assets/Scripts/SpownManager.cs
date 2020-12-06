using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;


    private void Start()
    {
        InvokeRepeating("SpownRandomAnimal", startDelay, spawnInterval);
    }
    void Update()
    {
        
    }

    void SpownRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spownPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spownPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

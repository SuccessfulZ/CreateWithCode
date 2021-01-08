using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    int ballAmount;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DelayedSpawnRandomBall", Random.Range(3,5));
        ballAmount = ballPrefabs.Length;
    }
     void DelayedSpawnRandomBall()
    {
        SpawnRandomBall();
        Invoke("DelayedSpawnRandomBall",Random.Range(3, 5));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballNumber = Random.Range(0, ballAmount);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
    }

}

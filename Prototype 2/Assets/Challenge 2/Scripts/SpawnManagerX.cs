﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    public float minSpawnInterval = 3;
    public float maxSpawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }
    
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {   
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballIndex = Random.Range(0,ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // change delay for upcoming spawn
        float nextSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);

        // plan next Spawn
        Invoke("SpawnRandomBall", nextSpawnInterval);
    }

}

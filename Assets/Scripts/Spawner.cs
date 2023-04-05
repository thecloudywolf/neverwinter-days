using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] zombiePrefabs;
    private float xSpawnRange = 70;
    private float zSpawnRange = 70;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomZombie", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomZombie()
    {
        int zombieindex = Random.Range(0, zombiePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, Random.Range(-zSpawnRange, zSpawnRange));

        Instantiate(zombiePrefabs[zombieindex], spawnPos, zombiePrefabs[zombieindex].transform.rotation);
    }
}
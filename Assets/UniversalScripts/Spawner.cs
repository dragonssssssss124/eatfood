using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float minX = -5f;   // left boundary
    public float maxX = 5f;    // right boundary
    public float fixedY = 1f;  // constant Y position

    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, fixedY, 0f);

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
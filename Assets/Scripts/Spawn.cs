using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnAreaWidth = 10f;
    public float spawnAreaHeight = 10f;

    public float timer;
    public float timerSpawn;

    public int SpawnCount;
    public int MaxSpawnCount;
    
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if(SpawnCount < MaxSpawnCount)
        {
            if (timer >= timerSpawn)
            {
                SpawnPrefab();
                SpawnCount++;
                timer = 0f;
            }
        }

    }

    void SpawnPrefab()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnAreaWidth / 2f, spawnAreaWidth / 2f),
                                            Random.Range(-spawnAreaHeight / 2f, spawnAreaHeight / 2f));

        GameObject newPrefab = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(spawnAreaWidth, spawnAreaHeight, 0f));
    }
}

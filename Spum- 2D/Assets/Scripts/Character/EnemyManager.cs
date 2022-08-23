using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    public int minX, maxX;
    public int minY, maxY;

    public GameObject[] listEnemy;
    public float spawnRate;

    public GameObject[] listBoss;
    public float bossSpawnRate;

    public LevelPlayer LevelPlayer;

    private float randx, randy;
    Vector2 whereToSpawn;

    void Start()
    {
        StartCoroutine(SpawnPositionEnemy(listEnemy, spawnRate));
        StartCoroutine(SpawnPositionEnemy(listBoss, bossSpawnRate));
    }

    private IEnumerator SpawnPositionEnemy(GameObject[] listBoth, float spawnRate)
    {
        yield return new WaitForSeconds(spawnRate);
        randx = Random.Range(minX, maxX);
        randy = Random.Range(minY, maxY);
        whereToSpawn = new Vector2(randx, randy);
        var newEnemy = Instantiate(listBoth[0], whereToSpawn, Quaternion.identity);
        StartCoroutine(SpawnPositionEnemy(listBoth, spawnRate));
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        if (LevelPlayer.level >= 2)
        {
            spawnRate = 1f;
            Instantiate(listEnemy[Random.Range(0, 2)], whereToSpawn, Quaternion.identity, transform);
        }
        if (LevelPlayer.level >= 3)
        {
            Instantiate(listEnemy[Random.Range(0, 3)], whereToSpawn, Quaternion.identity,transform);
        }
        if (LevelPlayer.level >= 4)
        {
            spawnRate = 0.9f;
            Instantiate(listEnemy[Random.Range(0, 4)], whereToSpawn, Quaternion.identity,transform);
        }
        if (LevelPlayer.level >= 5)
        {
            Instantiate(listEnemy[Random.Range(1, 5)], whereToSpawn, Quaternion.identity,transform);
        }
        if (LevelPlayer.level >= 6)
        {
            spawnRate = 0.8f;
            Instantiate(listEnemy[Random.Range(1, 6)], whereToSpawn, Quaternion.identity, transform);
        }
        if (LevelPlayer.level >= 7)
        {
            Instantiate(listEnemy[Random.Range(2, 7)], whereToSpawn, Quaternion.identity, transform);
        }
        if (LevelPlayer.level >= 8)
        {
            spawnRate = 1.5f;
            Instantiate(listEnemy[Random.Range(3, listEnemy.Length)], whereToSpawn, Quaternion.identity, transform);
        }
    }
}

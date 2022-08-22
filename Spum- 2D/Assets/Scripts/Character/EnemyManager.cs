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
    float nextSpawn = 0.0f;

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
            spawnRate = 0.45f;
            Instantiate(listEnemy[Random.Range(0, 2)], whereToSpawn, Quaternion.identity, transform);
        }
        if (LevelPlayer.level >= 3)
        {
            spawnRate = 0.4f;
            Instantiate(listEnemy[Random.Range(0, 3)], whereToSpawn, Quaternion.identity,transform);
        }
        if (LevelPlayer.level >= 5)
        {
            spawnRate = 0.35f;
            Instantiate(listEnemy[Random.Range(0, 4)], whereToSpawn, Quaternion.identity,transform);
        }
        if (LevelPlayer.level >= 6)
        {
            Instantiate(listEnemy[Random.Range(1, 4)], whereToSpawn, Quaternion.identity,transform);
        }
    }
}

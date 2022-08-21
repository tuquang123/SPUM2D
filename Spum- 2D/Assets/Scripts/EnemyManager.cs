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
    public LevelPlayer LevelPlayer;
    private float randx, randy;
    public float spawnRate;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randx = Random.Range(minX, maxX);
            randy = Random.Range(minY, maxY);
            whereToSpawn = new Vector2(randx, randy);
            Instantiate(listEnemy[0], whereToSpawn, Quaternion.identity);
            if (LevelPlayer.level > 1)
            {
                spawnRate = 0.7f;
                Instantiate(listEnemy[Random.Range(0, 2)], whereToSpawn, Quaternion.identity);
            }
            if (LevelPlayer.level > 2)
            {
                spawnRate = 0.65f;
                Instantiate(listEnemy[Random.Range(0, 3)], whereToSpawn, Quaternion.identity);
            }
            if (LevelPlayer.level > 3)
            {
                spawnRate = 0.55f;
                Instantiate(listEnemy[Random.Range(0, 4)], whereToSpawn, Quaternion.identity);
            }
            if (LevelPlayer.level > 4)
            {
                //Instantiate(listEnemy[Random.Range(0, 4)], whereToSpawn, Quaternion.identity);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManager : MonoBehaviour
{
    public int minX, maxX;
    public int minY, maxY;
    public GameObject enemy;
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
            whereToSpawn = new Vector2(randx,randy);
            Instantiate(enemy, whereToSpawn, Quaternion.identity,transform);
        }
    }
}

